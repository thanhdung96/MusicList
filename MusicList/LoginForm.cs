using System;
using System.Windows.Forms;
using MusicListLibrary.Models;
using MusicListLibrary.Controllers;

namespace MusicList
{
	public partial class LoginForm : Form
	{
		private Users user;
		public Users User {
			get{ return this.user; }
		}
		private UsersController userController;

		public LoginForm()
		{
			InitializeComponent();
			userController = new UsersController();
			user = new Users();
			userController.AddUser(ref user);
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
	}
}
