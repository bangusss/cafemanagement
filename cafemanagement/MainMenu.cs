/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/6/2023
 * Time: 11:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanagement
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Label2Click(object sender, EventArgs e)
		{
			AddProducts Obj = new AddProducts();
			Obj.Show();
			Obj.TopMost = true;
		}
		void Label4Click(object sender, EventArgs e)
		{
			AddSuppliers Obj = new AddSuppliers();
			Obj.Show();
			Obj.TopMost = true;
		}
		void Label6Click(object sender, EventArgs e)
		{
			AddCustomers Obj = new AddCustomers();
			Obj.Show();
			Obj.TopMost = true;
		}
		void Label3Click(object sender, EventArgs e)
		{
			ViewProducts Obj = new ViewProducts();
			Obj.Show();
			this.Hide();
		}
		void Label5Click(object sender, EventArgs e)
		{
			ViewSupplier Obj = new ViewSupplier();
			Obj.Show();
			this.Hide();
		}
		void Label7Click(object sender, EventArgs e)
		{
			ViewCustomers Obj = new ViewCustomers();
			Obj.Show();
			this.Hide();
		}
	}
}
