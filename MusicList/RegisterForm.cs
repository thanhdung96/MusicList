using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using MusicListLibrary.Controllers;
using MusicListLibrary.Models;

namespace MusicList
{
	public partial class RegisterForm : Form
	{
		private Users user;
		private UsersController userController;
		private List<bool> ErrorList;		//true is validate failure
		private bool registered = false;
		
		public RegisterForm()
		{
			InitializeComponent();
			
			this.cbxGender.SelectedIndex = 0;
			userController = new UsersController();
			ErrorList = new List<bool>(5);
			for (int i = 0; i < 5; i++)
				ErrorList.Add(false);
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}
		
		async void BtnRegisterClick(object sender, EventArgs e)
		{
			this.user = new Users();
			bool passed = true;
			foreach (Control control in this.Controls) {
				control.Focus();
			}
			foreach (bool ValidateFailed in ErrorList) {
				if(ValidateFailed){
					passed=false;
					MessageBox.Show("Verify information");
					break;
				}
			}
			
			if(passed){
				await Task.Run(() => RegisterThread());
				if(registered){
					this.Dispose(true);
				}
			}
		}
		
		private async void RegisterThread()
		{
			this.user.Email = this.txtEmail.Text;
			this.user.Fullname = this.txtFullname.Text;
			this.user.Password = this.txtPassword.Text;
			this.user.Gender = (this.cbxGender.SelectedIndex == 1);
			this.user.DOB = this.dtpDOB.Value;
			this.user.TimeStamp = DateTime.Today;
			
			if (userController.AddUser(ref this.user)) {
				CustomMessageBox.Show("Your Account has been Registered.", "Yay!!", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
				registered=true;
			} else {
				CustomMessageBox.Show("Email already exist.\nPlease use a different email.", "Hold up!!", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Exclamation, CustomMessageBox.AnimateStyle.FadeIn);
			}
		}
		
		private void DisableControls(bool enabled)
		{
			this.txtEmail.Enabled = enabled;
			this.txtFullname.Enabled = enabled;
			this.txtPassword.Enabled = enabled;
			this.cbxGender.Enabled = enabled;
			this.dtpDOB.Enabled = enabled;
			this.btnRegister.Enabled = enabled;
			this.btnCancel.Enabled = enabled;
			this.Cursor = !enabled ? Cursors.WaitCursor : Cursors.Arrow;
		}
		
		#region Validating
		void TxtFullnameValidating(object sender, CancelEventArgs e)
		{
			const string FullnameRegex = @"^[a-zA-Z\s]+$";
			if (string.IsNullOrEmpty(this.txtFullname.Text)) {
				ErrorPrivider.SetError(this.txtFullname, "Enter your name");
				ErrorList[0] = true;
			} else if (!Regex.IsMatch(this.txtFullname.Text, FullnameRegex)) {
				ErrorPrivider.SetError(this.txtFullname, "Strange Name");
				ErrorList[0] = true;
			} else {
				ErrorPrivider.SetError(this.txtFullname, null);
				ErrorList[0] = false;
			}
		}
		void TxtEmailValidating(object sender, CancelEventArgs e)
		{
			const string EmailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
			if (String.IsNullOrEmpty(this.txtEmail.Text)) {
				ErrorPrivider.SetError(this.txtEmail, "Give us your email, moron!");
				ErrorList[1] = true;
			} else if (!Regex.IsMatch(this.txtEmail.Text, EmailRegex)) {
				ErrorPrivider.SetError(this.txtEmail, "Invalid email format!");
				ErrorList[1] = true;
			} else {
				ErrorPrivider.SetError(this.txtEmail, null);
				ErrorList[1] = false;
			}
		}
		void TxtPasswordValidating(object sender, CancelEventArgs e)
		{
			const string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$";
			if (String.IsNullOrEmpty(this.txtPassword.Text)) {
				ErrorPrivider.SetError(this.txtPassword, "Empty password");
				ErrorList[2] = true;
			} else if (!Regex.IsMatch(this.txtPassword.Text, PasswordRegex)) {
				ErrorPrivider.SetError(this.txtPassword, "Password must be at least:\n1 uppercase,\n1 lowercase,\n1 special character\n 8 to 20 characters wide.");
				ErrorList[2] = true;
			} else {
				ErrorPrivider.SetError(this.txtPassword, null);
				ErrorList[2] = false;
			}
		}
		void TxtConfirmValidating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(this.txtConfirm.Text)) {
				ErrorPrivider.SetError(this.txtConfirm, "Please confirm your password");
				ErrorList[3] = true;
			} else if (!this.txtConfirm.Text.Equals(this.txtPassword.Text)) {
				ErrorPrivider.SetError(this.txtConfirm, "Confirm password is not match");
				ErrorList[3] = true;
			} else {
				ErrorPrivider.SetError(this.txtConfirm, null);
				ErrorList[3] = false;
			}
		}
		void DtpDOBValidating(object sender, CancelEventArgs e)
		{
			if(this.dtpDOB.Value >= DateTime.Today){
				ErrorPrivider.SetError(this.dtpDOB, "So fictional date of birth");
				ErrorList[4] = true;
			}else {
				ErrorPrivider.SetError(this.dtpDOB, null);
				ErrorList[4] = false;
			}
		}
		#endregion Validating
	}
}
