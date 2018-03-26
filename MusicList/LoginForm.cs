using System;
using System.Windows.Forms;
using MusicListLibrary.Controllers;
using MusicListLibrary.Models;
using System.Threading.Tasks;
using CustomControls;
using System.Text.RegularExpressions;

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
		async void BtnLoginClick(object sender, EventArgs e)
		{
			DisableControls(false);
			await Task.Run(() => LoginThread());	//this is the way it suppose to be. dont mend this
			
			if (MainForm.session == null) {
				CustomMessageBox.Show("Seems like that user doesn\'t exist. Try again", "Oops", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Warning);
				DisableControls(true);
			} else {
				this.LoginOK = true;
				CustomMessageBox.Show("Welcome back, " + MainForm.session.Fullname, "Welcome back!!", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info);
				this.Dispose();
			}
		}
		
		private async void LoginThread()
		{
			user.Email = this.txtUsername.Text;
			user.Password = this.txtPassword.Text;
			MainForm.session = userController.Login(ref user);
		}
		
		private void DisableControls(bool enabled)
		{
			this.btnLogin.Enabled = enabled;
			this.btnCancel.Enabled = enabled;
			this.btnRegister.Enabled = enabled;
			this.btnShow.Enabled = enabled;
			this.Cursor = !enabled ? Cursors.WaitCursor : Cursors.Arrow;
		}
		
		void TxtUsernameValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			const string EmailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
			if (String.IsNullOrEmpty(this.txtUsername.Text)) {
				emailError.SetError(this.txtUsername, "Give us your email, moron!");
				this.btnLogin.Enabled = false;
			} else if (!Regex.IsMatch(this.txtUsername.Text, EmailRegex)) {
				emailError.SetError(this.txtUsername, "Invalid email format!");
				this.btnLogin.Enabled = false;
			} else {
				emailError.SetError(this.txtUsername, null);
				this.btnLogin.Enabled = true;
			}
		}
	}
}
