using System;
using System.Windows.Forms;
using MusicListLibrary.Controllers;
using MusicListLibrary.Models;
using CustomControls;

namespace MusicList
{
	public partial class LoginForm : Form
	{
		private Users user;
		public bool LoginOK{ get; set; }
		private UsersController userController;

		public LoginForm()
		{
			InitializeComponent();
			userController = new UsersController();
			user = new Users();
			this.LoginOK = false;
		}
		
		void BtnRegisterClick(object sender, EventArgs e)
		{
			RegisterForm reg = new RegisterForm();
			reg.ShowInTaskbar = false;
			reg.ShowDialog(this);
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}
		void BtnShowMouseDown(object sender, MouseEventArgs e)
		{
			this.txtPassword.UseSystemPasswordChar = false;
		}
		void BtnShowMouseUp(object sender, MouseEventArgs e)
		{
			this.txtPassword.UseSystemPasswordChar = true;
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
			this.user.Email = this.txtUsername.Text;
			this.user.Password = this.txtPassword.Text;
			MainForm.session = userController.Login(ref this.user);
			if (MainForm.session == null) {
				CustomMessageBox.Show("Seems like that user doesn\'t exist. Try again", "Oops", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Warning);
			} else {
				this.LoginOK = true;
				CustomMessageBox.Show("Welcome back, " + MainForm.session.Fullname, "Welcome back!!", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info);
				this.Dispose();
			}
		}
	}
}
