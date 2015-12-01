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
namespace SyncTcpClient_0
{
	public partial class Form1
	{
		internal Form1()
		{
			InitializeComponent();
		}

		private TcpClient myTcpClient;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			Button1.Enabled = true;
			Button2.Enabled = false;
			Button3.Enabled = false;
		}
		private void Button1_Click(object sender, System.EventArgs e)
		{
			Button1.Enabled = false;
			IPEndPoint myIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
			myTcpClient = new TcpClient(myIPEndPoint);
			IPAddress ServerIpAddress = null;
			try
			{
				ServerIpAddress = IPAddress.Parse(TextBox1.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Server IP設定錯誤");
				return;
			}
			int iPort = 0;
            iPort = Convert.ToInt32(NumericUpDown1.Value);
			IPEndPoint RemoteIpEndPoint = new IPEndPoint(ServerIpAddress, iPort);

			try
			{
				myTcpClient.Connect(RemoteIpEndPoint);

				do
				{
					if (myTcpClient.Connected == true)
					{
						Label4.Text = "連線中";
						Button1.Enabled = false;
						Button2.Enabled = true;
						Button3.Enabled = true;
						break;
					}
				} while (true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				Label4.Text = "未連線";
				Button1.Enabled = true;
				Button2.Enabled = false;
				Button3.Enabled = false;
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			IPAddress ServerIpAddress = null;
			try
			{
				ServerIpAddress = IPAddress.Parse(TextBox1.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Server IP設定錯誤");
				return;
			}
			int iPort = 0;
            iPort = Convert.ToInt32(NumericUpDown1.Value);
			IPEndPoint RemoteIpEndPoint = new IPEndPoint(ServerIpAddress, iPort);
			NetworkStream myNetworkStream = null;
			byte[] myBytes = null;

			myBytes = Encoding.GetEncoding(950).GetBytes(TextBox2.Text.Trim(' ').TrimEnd());
			try
			{
				myNetworkStream = myTcpClient.GetStream();
				myNetworkStream.Write(myBytes, 0, myBytes.Length);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			myTcpClient.Close();
			Label4.Text = "未連線";
			Button1.Enabled = true;
			Button2.Enabled = false;
			Button3.Enabled = false;
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