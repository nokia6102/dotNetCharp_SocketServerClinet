﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.18033
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------




//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SyncTCPServer_1
{
	namespace My
	{

		//注意: 這是自動產生的檔案，請勿直接修改它。若要進行變更，
		// 或者您在這個檔案發生建置錯誤，請到專案設計工具
		// (移至專案屬性或者在 [方案總管] 中按兩下 [My Project] 節點)，
		// 然後在 [應用程式] 索引標籤上進行變更。
		//
		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{

			[global::System.Diagnostics.DebuggerStepThroughAttribute()]
			public MyApplication() : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				this.IsSingleInstance = false;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
			}

			[global::System.Diagnostics.DebuggerStepThroughAttribute()]
			protected override void OnCreateMainForm()
			{
				this.MainForm = global::SyncTCPServer_1.Form1.DefaultInstance;
			}

			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

			[STAThread]
			static void Main(string[] args)
			{
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
				MyApp = new MyApplication();
				MyApp.Run(args);
			}

		}
	}

}