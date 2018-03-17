using System;
using System.Windows.Forms;
using MusicListLibrary.Models;
using MusicListLibrary.Controllers;
using CustomControls;

namespace MusicList
{
	public partial class RegisterForm : Form
	{
		private Users user;
		private UsersController userController;
		
		public RegisterForm()
		{
			InitializeComponent();
			
			this.cbxGender.SelectedIndex = 0;
			userController = new UsersController();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}
		
		void BtnRegisterClick(object sender, EventArgs e)
		{
			this.user = new Users();
			this.user.Email = this.txtEmail.Text;
			this.user.Fullname = this.txtFullname.Text;
			this.user.Password = this.txtPassword.Text;
			this.user.Gender = Convert.ToBoolean(this.cbxGender.SelectedIndex);
			this.user.DOB = this.dtpDOB.Value;
			if(userController.AddUser(ref this.user))
				CustomMessageBox.Show("Registered", "Registered", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
			else
				;
		}
	}
}
