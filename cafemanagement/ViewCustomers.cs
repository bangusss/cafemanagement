﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/7/2023
 * Time: 5:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanagement
{
	/// <summary>
	/// Description of ViewCustomers.
	/// </summary>
	public partial class ViewCustomers : Form
	{
		public ViewCustomers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button3Click(object sender, EventArgs e)
		{
			MainForm Obj = new MainForm();
			Obj.Show();
			this.Close();
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
