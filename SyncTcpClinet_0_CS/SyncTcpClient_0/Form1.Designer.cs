//INSTANT C# NOTE: Formerly VB project-level imports:
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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class Form1 : System.Windows.Forms.Form
	{
		//Form 覆寫 Dispose 以清除元件清單。
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//為 Windows Form 設計工具的必要項
		private System.ComponentModel.IContainer components;

		//注意: 以下為 Windows Form 設計工具所需的程序
		//可以使用 Windows Form 設計工具進行修改。
		//請不要使用程式碼編輯器進行修改。
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(28, 38);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(75, 12);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "遠端伺服器IP";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(120, 28);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(221, 22);
			this.TextBox1.TabIndex = 2;
			this.TextBox1.Text = "127.000.000.001";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(28, 72);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(84, 12);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "遠端伺服器Port";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(120, 62);
			this.NumericUpDown1.Maximum = new decimal(new int[] {65535, 0, 0, 0});
			this.NumericUpDown1.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(120, 22);
			this.NumericUpDown1.TabIndex = 7;
			this.NumericUpDown1.Value = new decimal(new int[] {9999, 0, 0, 0});
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(26, 108);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(77, 12);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "要發送的文字";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(118, 105);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(221, 22);
			this.TextBox2.TabIndex = 11;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(28, 140);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 12;
			this.Button1.Text = "連接";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(118, 140);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 13;
			this.Button2.Text = "發送";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(199, 140);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 14;
			this.Button3.Text = "離線";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(28, 9);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(41, 12);
			this.Label4.TabIndex = 15;
			this.Label4.Text = "未連線";
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 12.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 173);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label1);
			this.Name = "Form1";
			this.Text = "TCP Client";
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted event handler wireups:
			base.Load += new System.EventHandler(Form1_Load);
			Button1.Click += new System.EventHandler(Button1_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
			Button3.Click += new System.EventHandler(Button3_Click);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Label Label4;

	}

}