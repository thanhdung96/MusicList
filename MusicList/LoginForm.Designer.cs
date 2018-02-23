/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Feb.20.2018
 * Time: 21:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MusicList
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
		private MaterialSkin.Controls.MaterialRaisedButton btnShow;
		private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private MaterialSkin.Controls.MaterialFlatButton btnRegister;
		private MaterialSkin.Controls.MaterialFlatButton btnCancel;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnShow = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnRegister = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.4965F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.5035F));
			this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnLogin, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 136);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(14, 0);
			this.materialLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(100, 34);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Username:";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(11, 34);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(100, 34);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Password:";
			this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUsername
			// 
			this.txtUsername.Depth = 0;
			this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUsername.Hint = "";
			this.txtUsername.Location = new System.Drawing.Point(117, 3);
			this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.SelectedText = "";
			this.txtUsername.SelectionLength = 0;
			this.txtUsername.SelectionStart = 0;
			this.txtUsername.Size = new System.Drawing.Size(369, 23);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.UseSystemPasswordChar = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.25698F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.74302F));
			this.tableLayoutPanel2.Controls.Add(this.txtPassword, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnShow, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(114, 34);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 34);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Depth = 0;
			this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPassword.Hint = "";
			this.txtPassword.Location = new System.Drawing.Point(0, 0);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
			this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.Size = new System.Drawing.Size(285, 23);
			this.txtPassword.TabIndex = 0;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnShow
			// 
			this.btnShow.Depth = 0;
			this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnShow.Location = new System.Drawing.Point(288, 3);
			this.btnShow.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnShow.Name = "btnShow";
			this.btnShow.Primary = true;
			this.btnShow.Size = new System.Drawing.Size(84, 28);
			this.btnShow.TabIndex = 1;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.btnRegister, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 108);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(489, 28);
			this.tableLayoutPanel3.TabIndex = 7;
			// 
			// btnRegister
			// 
			this.btnRegister.AutoSize = true;
			this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnRegister.Depth = 0;
			this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRegister.Location = new System.Drawing.Point(0, 0);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
			this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Primary = false;
			this.btnRegister.Size = new System.Drawing.Size(244, 28);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCancel.Depth = 0;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(244, 0);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Primary = false;
			this.btnCancel.Size = new System.Drawing.Size(245, 28);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnLogin
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnLogin, 2);
			this.btnLogin.Depth = 0;
			this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLogin.Location = new System.Drawing.Point(3, 71);
			this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Primary = true;
			this.btnLogin.Size = new System.Drawing.Size(483, 34);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(499, 146);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
