/*
 * Created by SharpDevelop.
 * User: user
 * Date: 4/7/2023
 * Time: 4:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cafemanagement
{
	/// <summary>
	/// Description of AddProducts.
	/// </summary>
	public partial class AddProducts : Form
	{
		public AddProducts()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
