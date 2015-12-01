using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace SyncTCPServer_1
{
	public partial class Form1
	{
		internal Form1()
		{
			InitializeComponent();
		}

		private class CSState
		{
			public TcpListener myTcpListener;
			public Socket ClientSocket;
			public string mystring;
		}
		private DataTable myDatatable = new DataTable();
		private TcpListener myTcpListener;
		public delegate void SetMsgCallBack(object state);
		private void DisplayMsg1(object state)
		{
			CSState myObj = new CSState();
			myObj = (CSState)state;
			if (this.DataGridView1.InvokeRequired)
			{
				SetMsgCallBack d = new SetMsgCallBack(DisplayMsg1);
				this.Invoke(d, new object[] {myObj});
			}
			else
			{
				DataRow xRow = myDatatable.NewRow();
				xRow[0] = ((IPEndPoint)myObj.ClientSocket.RemoteEndPoint).Address.ToString();
				xRow[1] = ((IPEndPoint)myObj.ClientSocket.RemoteEndPoint).Port.ToString();
				xRow[2] = myObj.mystring;
				myDatatable.Rows.Add(xRow);
			}
		}
		public delegate void LbCallBack(string myString, Color myColor);
		private void ChangeLB(string myString, Color myColor)
		{
			if (this.Label2.InvokeRequired)
			{
				LbCallBack d = new LbCallBack(ChangeLB);
				this.Invoke(d, new object[] {myString, myColor});
			}
			else
			{
				Label2.Text = myString;
				Label2.ForeColor = myColor;
			}
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
			myDatatable.Columns.Add("IP");
			myDatatable.Columns.Add("Port");
			myDatatable.Columns.Add("Data");
			DataGridView1.DataSource = myDatatable;
			DataGridView1.Columns[2].Width = 150;
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			if (Button1.Enabled == true)
			{
				int iPort = 0;
                iPort = Convert.ToInt32(NumericUpDown1.Value);
				Button1.Enabled = false;
				Button2.Enabled = true;
				Thread ListenThread = new Thread(StartListen);

				ListenThread.IsBackground = true;
				ListenThread.Start(iPort);
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			if (Button2.Enabled == true)
			{
				myTcpListener.Stop();
				ChangeLB("TCP Listener 停止", Color.Red);
				Button1.Enabled = true;
				Button2.Enabled = false;
			}
		}
		private void StartListen(object state)
		{
			int iPort = 0;
			iPort = Convert.ToInt32(state);
			myTcpListener = new TcpListener(IPAddress.Any, iPort);
			try
			{
				Socket ClientSocket = null;
				myTcpListener.Start();
				int iCount = 0;
				ChangeLB("TCP Listener 已啟動", Color.Blue);
				do
				{
					ClientSocket = myTcpListener.AcceptSocket();
					if (ClientSocket.Connected == true)
					{
						CSState myObj = new CSState();
						myObj.myTcpListener = myTcpListener;
						myObj.ClientSocket = ClientSocket;
						myObj.mystring = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "已連線";
						DisplayMsg1(myObj);
						Thread ReceiveThread = new Thread(ReceiveData);
						ReceiveThread.IsBackground = true;
						ReceiveThread.Start(myObj);
						iCount += 1;
					}
				} while (true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void ReceiveData(object state)
		{
			CSState myObj = new CSState();
			myObj.ClientSocket = ((CSState)state).ClientSocket;
			myObj.myTcpListener = ((CSState)state).myTcpListener;
			myObj.mystring = "";
			NetworkStream myNetworkStream = new NetworkStream(myObj.ClientSocket);
			int InBytesCount = 0;
			byte[] myReceiveBytes = new byte[1024];
			int i = 0;
			while (true)
			{
				try
				{
					InBytesCount = myNetworkStream.Read(myReceiveBytes, 0, myReceiveBytes.Length);
					System.Threading.Thread.Sleep(100);
					if (InBytesCount == 0)
					{
						break;
					}
					myObj.mystring = Encoding.GetEncoding(950).GetString(myReceiveBytes).TrimEnd().TrimStart();
					DisplayMsg1(myObj);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return;
				}
			}
		}

	private static Form1 _DefaultInstance;
	public static Form1 DefaultInstance
	{
		get
		{
			if (_DefaultInstance == null)
				_DefaultInstance = new Form1();

			return _DefaultInstance;
		}
	}
	}

}