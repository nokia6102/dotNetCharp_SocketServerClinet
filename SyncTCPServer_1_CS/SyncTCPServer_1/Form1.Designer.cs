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
using System.Threading;

namespace SyncTCPServer_1
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
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Button2
			//
			this.Button2.Enabled = false;
			this.Button2.Location = new System.Drawing.Point(12, 267);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 16;
			this.Button2.Text = "停止";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(12, 238);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 15;
			this.Button1.Text = "啟動";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.Color.Red;
			this.Label2.Location = new System.Drawing.Point(10, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(93, 12);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "TCP Listener 停止";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(13, 24);
			this.NumericUpDown1.Maximum = new decimal(new int[] {65535, 0, 0, 0});
			this.NumericUpDown1.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(74, 22);
			this.NumericUpDown1.TabIndex = 13;
			this.NumericUpDown1.Value = new decimal(new int[] {9999, 0, 0, 0});
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(126, 9);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.RowTemplate.Height = 24;
			this.DataGridView1.Size = new System.Drawing.Size(473, 281);
			this.DataGridView1.TabIndex = 12;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(10, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(84, 12);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "輸入TCP Port號";
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 12.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 294);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.Label1);
			this.Name = "Form1";
			this.Text = "TCP Listener";
			((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted event handler wireups:
			base.Load += new System.EventHandler(Form1_Load);
			Button1.Click += new System.EventHandler(Button1_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
		}
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Label Label1;

	}

}