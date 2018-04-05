/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Apr 05.2018
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
	/// <summary>
	/// Description of CustomInputDialog.
	/// </summary>
	public partial class CustomInputDialog : Form
	{
       string input_text;
 
        public string ResultText
        {
            get { return input_text; }
            private set { input_text = value; }
        }
 
        public CustomInputDialog(string title, string label_text, string textbox_string)
        {
            InitializeComponent();
            this.Text = title;
            this.lblInput.Text = label_text;
            this.txtInput.Text = textbox_string;
        }
 
        public CustomInputDialog()
        {
            InitializeComponent();
        }
 
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim().Length > 0)
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }
 
        private void btnOk_Click(object sender, EventArgs e)
        {
            ResultText = txtInput.Text.Trim();
        }
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}
	}
}
