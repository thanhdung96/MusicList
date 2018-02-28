using System;
using System.Windows.Forms;

namespace MusicList
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
			
			this.cbxGender.SelectedIndex=0;
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
