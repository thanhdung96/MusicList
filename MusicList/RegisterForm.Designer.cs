/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Feb.22.2018
 * Time: 00:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MusicList
{
	using MaterialSkin.Controls;
	partial class RegisterForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private MaterialLabel materialLabel1;
		private MaterialSingleLineTextField txtFullname;
		private MaterialLabel materialLabel2;
		private MaterialSingleLineTextField txtEmail;
		private MaterialLabel materialLabel3;
		private MaterialSingleLineTextField txtPassword;
		private MaterialLabel materialLabel4;
		private MaterialRaisedButton btnRegister;
		private MaterialFlatButton btnCancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialLabel materialLabel5;
		private MaterialLabel materialLabel6;
		private MetroFramework.Controls.MetroDateTime dtpDOB;
		private MetroFramework.Controls.MetroComboBox cbxGender;
		private MaterialSingleLineTextField txtConfirm;
		
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
			this.txtFullname = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.dtpDOB = new MetroFramework.Controls.MetroDateTime();
			this.cbxGender = new MetroFramework.Controls.MetroComboBox();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
			this.txtConfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel1.Controls.Add(this.txtFullname, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRegister, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.txtConfirm, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 329);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtFullname
			// 
			this.txtFullname.Depth = 0;
			this.txtFullname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFullname.Hint = "";
			this.txtFullname.Location = new System.Drawing.Point(143, 25);
			this.txtFullname.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.txtFullname.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.PasswordChar = '\0';
			this.txtFullname.SelectedText = "";
			this.txtFullname.SelectionLength = 0;
			this.txtFullname.SelectionStart = 0;
			this.txtFullname.Size = new System.Drawing.Size(417, 23);
			this.txtFullname.TabIndex = 1;
			this.txtFullname.Text = "Dung Duong";
			this.txtFullname.UseSystemPasswordChar = false;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(8, 52);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(132, 47);
			this.materialLabel2.TabIndex = 2;
			this.materialLabel2.Text = "Email:";
			this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmail
			// 
			this.txtEmail.Depth = 0;
			this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEmail.Hint = "";
			this.txtEmail.Location = new System.Drawing.Point(143, 72);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.SelectedText = "";
			this.txtEmail.SelectionLength = 0;
			this.txtEmail.SelectionStart = 0;
			this.txtEmail.Size = new System.Drawing.Size(417, 23);
			this.txtEmail.TabIndex = 3;
			this.txtEmail.Text = "123@abc.com";
			this.txtEmail.UseSystemPasswordChar = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(8, 99);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(132, 47);
			this.materialLabel3.TabIndex = 4;
			this.materialLabel3.Text = "Password:";
			this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPassword
			// 
			this.txtPassword.Depth = 0;
			this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPassword.Hint = "";
			this.txtPassword.Location = new System.Drawing.Point(143, 119);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.Size = new System.Drawing.Size(417, 23);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.Text = "123";
			this.txtPassword.UseSystemPasswordChar = false;
			// 
			// materialLabel4
			// 
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(8, 146);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(132, 47);
			this.materialLabel4.TabIndex = 6;
			this.materialLabel4.Text = "Confirm Password:";
			this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
			this.btnCancel.Depth = 0;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(55, 279);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
			this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Primary = false;
			this.btnCancel.Size = new System.Drawing.Size(455, 45);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
			this.tableLayoutPanel2.Controls.Add(this.materialLabel5, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.dtpDOB, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbxGender, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.materialLabel6, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 198);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 37);
			this.tableLayoutPanel2.TabIndex = 10;
			// 
			// materialLabel5
			// 
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel5.Location = new System.Drawing.Point(3, 0);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(105, 37);
			this.materialLabel5.TabIndex = 0;
			this.materialLabel5.Text = "Gender:";
			this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDOB
			// 
			this.dtpDOB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtpDOB.Location = new System.Drawing.Point(347, 3);
			this.dtpDOB.MinimumSize = new System.Drawing.Size(0, 29);
			this.dtpDOB.Name = "dtpDOB";
			this.dtpDOB.Size = new System.Drawing.Size(205, 29);
			this.dtpDOB.TabIndex = 2;
			// 
			// cbxGender
			// 
			this.cbxGender.FormattingEnabled = true;
			this.cbxGender.ItemHeight = 23;
			this.cbxGender.Items.AddRange(new object[] {
			"Female",
			"Male"});
			this.cbxGender.Location = new System.Drawing.Point(114, 3);
			this.cbxGender.Name = "cbxGender";
			this.cbxGender.Size = new System.Drawing.Size(105, 29);
			this.cbxGender.TabIndex = 3;
			this.cbxGender.UseSelectable = true;
			// 
			// materialLabel6
			// 
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(225, 0);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(116, 37);
			this.materialLabel6.TabIndex = 1;
			this.materialLabel6.Text = "Day of Birth:";
			this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(8, 5);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(132, 47);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Fullname:";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRegister
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnRegister, 2);
			this.btnRegister.Depth = 0;
			this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRegister.Location = new System.Drawing.Point(55, 240);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
			this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Primary = true;
			this.btnRegister.Size = new System.Drawing.Size(455, 39);
			this.btnRegister.TabIndex = 12;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
			// 
			// txtConfirm
			// 
			this.txtConfirm.Depth = 0;
			this.txtConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtConfirm.Hint = "";
			this.txtConfirm.Location = new System.Drawing.Point(143, 166);
			this.txtConfirm.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
			this.txtConfirm.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.SelectedText = "";
			this.txtConfirm.SelectionLength = 0;
			this.txtConfirm.SelectionStart = 0;
			this.txtConfirm.Size = new System.Drawing.Size(417, 23);
			this.txtConfirm.TabIndex = 13;
			this.txtConfirm.UseSystemPasswordChar = false;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(575, 339);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
