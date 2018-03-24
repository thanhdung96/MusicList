using System;
using System.Windows.Forms;
using CustomControls;
using MusicListLibrary.Controllers;
using MusicListLibrary.Models;

namespace MusicList
{
	public partial class RegisterForm : Form
	{
		/*
		 * TODO: add validations to this form
		 */
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
			this.user.Gender = (this.cbxGender.SelectedIndex == 1);
			this.user.DOB = this.dtpDOB.Value;
			this.user.TimeStamp = DateTime.Today;
			
			if (userController.AddUser(ref this.user)) {
				CustomMessageBox.Show("Your Account has been Registered.", "Yay!!", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
				this.Dispose(true);
			} else{
				CustomMessageBox.Show("Email already exist.\nPlease use a different email.", "Hold up!!", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Exclamation, CustomMessageBox.AnimateStyle.FadeIn);
			}
		}
	}
}
