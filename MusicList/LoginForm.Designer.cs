/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Feb.20.2018
 * Time: 21:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
using System.ComponentModel;
using MaterialSkin.Controls;

namespace MusicList
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private IContainer components = null;
		private TableLayoutPanel tableLayoutPanel1;
		private MaterialLabel materialLabel1;
		private MaterialLabel materialLabel2;
		private MaterialSingleLineTextField txtUsername;
		private TableLayoutPanel tableLayoutPanel2;
		private MaterialSingleLineTextField txtPassword;
		private MaterialRaisedButton btnShow;
		private MaterialRaisedButton btnLogin;
		private TableLayoutPanel tableLayoutPanel3;
		private MaterialFlatButton btnRegister;
		private MaterialFlatButton btnCancel;
		private ErrorProvider emailError;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new Container();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.materialLabel1 = new MaterialLabel();
			this.materialLabel2 = new MaterialLabel();
			this.txtUsername = new MaterialSingleLineTextField();
			this.tableLayoutPanel2 = new TableLayoutPanel();
			this.txtPassword = new MaterialSingleLineTextField();
			this.btnShow = new MaterialRaisedButton();
			this.tableLayoutPanel3 = new TableLayoutPanel();
			this.btnRegister = new MaterialFlatButton();
			this.btnCancel = new MaterialFlatButton();
			this.btnLogin = new MaterialRaisedButton();
			this.emailError = new ErrorProvider(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((ISupportInitialize)(this.emailError)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4965F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.5035F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
			this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnLogin, 0, 2);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 155);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Dock = DockStyle.Right;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(0, 0);
			this.materialLabel1.Margin = new Padding(0);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(97, 38);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Email:";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Dock = DockStyle.Right;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(3, 38);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(91, 38);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Password:";
			this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUsername
			// 
			this.txtUsername.CausesValidation = false;
			this.txtUsername.Depth = 0;
			this.txtUsername.Dock = DockStyle.Fill;
			this.txtUsername.Hint = "";
			this.txtUsername.Location = new System.Drawing.Point(100, 3);
			this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.SelectedText = "";
			this.txtUsername.SelectionLength = 0;
			this.txtUsername.SelectionStart = 0;
			this.txtUsername.Size = new System.Drawing.Size(311, 23);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.Text = "123@abc.com";
			this.txtUsername.UseSystemPasswordChar = false;
			this.txtUsername.Validating += new CancelEventHandler(this.TxtUsernameValidating);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.25698F));
			this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.74302F));
			this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.txtPassword, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnShow, 1, 0);
			this.tableLayoutPanel2.Dock = DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(97, 38);
			this.tableLayoutPanel2.Margin = new Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 38);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.CausesValidation = false;
			this.txtPassword.Depth = 0;
			this.txtPassword.Dock = DockStyle.Fill;
			this.txtPassword.Hint = "";
			this.txtPassword.Location = new System.Drawing.Point(3, 3);
			this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.Size = new System.Drawing.Size(267, 23);
			this.txtPassword.TabIndex = 0;
			this.txtPassword.Text = "123";
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnShow
			// 
			this.btnShow.CausesValidation = false;
			this.btnShow.Depth = 0;
			this.btnShow.Dock = DockStyle.Fill;
			this.btnShow.Location = new System.Drawing.Point(276, 3);
			this.btnShow.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnShow.Name = "btnShow";
			this.btnShow.Primary = true;
			this.btnShow.Size = new System.Drawing.Size(80, 32);
			this.btnShow.TabIndex = 1;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.MouseDown += new MouseEventHandler(this.BtnShowMouseDown);
			this.btnShow.MouseUp += new MouseEventHandler(this.BtnShowMouseUp);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
			this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.btnRegister, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
			this.tableLayoutPanel3.Dock = DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 122);
			this.tableLayoutPanel3.Margin = new Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(456, 33);
			this.tableLayoutPanel3.TabIndex = 7;
			// 
			// btnRegister
			// 
			this.btnRegister.AutoSize = true;
			this.btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnRegister.CausesValidation = false;
			this.btnRegister.Depth = 0;
			this.btnRegister.Dock = DockStyle.Fill;
			this.btnRegister.Location = new System.Drawing.Point(0, 0);
			this.btnRegister.Margin = new Padding(0);
			this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Primary = false;
			this.btnRegister.Size = new System.Drawing.Size(228, 33);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.btnCancel.CausesValidation = false;
			this.btnCancel.Depth = 0;
			this.btnCancel.Dock = DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(228, 0);
			this.btnCancel.Margin = new Padding(0);
			this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Primary = false;
			this.btnCancel.Size = new System.Drawing.Size(228, 33);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnLogin
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnLogin, 3);
			this.btnLogin.Depth = 0;
			this.btnLogin.Dock = DockStyle.Fill;
			this.btnLogin.Location = new System.Drawing.Point(3, 79);
			this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Primary = true;
			this.btnLogin.Size = new System.Drawing.Size(450, 40);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// emailError
			// 
			this.emailError.ContainerControl = this;
			this.emailError.Icon = resource.cancel_1;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(466, 165);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Padding = new Padding(5);
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "LoginForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((ISupportInitialize)(this.emailError)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
