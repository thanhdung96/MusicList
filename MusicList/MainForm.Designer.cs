/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Feb.20.2018
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MusicList
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private MaterialSkin.Controls.MaterialTabControl tcMainTabControl;
		private System.Windows.Forms.TabPage tabpage1;
		private System.Windows.Forms.TabPage tabPage2;
		private MaterialSkin.Controls.MaterialTabSelector tsMainTab;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Label lblTabName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblFullname;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialLabel lblGender;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MetroFramework.Controls.MetroDateTime metroDateTime1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
		
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
			this.tcMainTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.tabpage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.lblGender = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.tsMainTab = new MaterialSkin.Controls.MaterialTabSelector();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.lblTabName = new System.Windows.Forms.Label();
			this.lblFullname = new System.Windows.Forms.Label();
			this.tcMainTabControl.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMainTabControl
			// 
			this.tcMainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tcMainTabControl.Controls.Add(this.tabpage1);
			this.tcMainTabControl.Controls.Add(this.tabPage2);
			this.tcMainTabControl.Controls.Add(this.tabPage3);
			this.tcMainTabControl.Depth = 0;
			this.tcMainTabControl.Location = new System.Drawing.Point(0, 62);
			this.tcMainTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.tcMainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.tcMainTabControl.Name = "tcMainTabControl";
			this.tcMainTabControl.SelectedIndex = 0;
			this.tcMainTabControl.Size = new System.Drawing.Size(1031, 398);
			this.tcMainTabControl.TabIndex = 0;
			// 
			// tabpage1
			// 
			this.tabpage1.Location = new System.Drawing.Point(4, 22);
			this.tabpage1.Name = "tabpage1";
			this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabpage1.Size = new System.Drawing.Size(1023, 372);
			this.tabpage1.TabIndex = 0;
			this.tabpage1.Text = "Explore";
			this.tabpage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1023, 372);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "My Playlist";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tableLayoutPanel1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1023, 372);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Account";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.15733F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.84267F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.materialSingleLineTextField1, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.materialSingleLineTextField2, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.materialSingleLineTextField3, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 366);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(23, 20);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(190, 58);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Fullname:";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(23, 78);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(190, 58);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Email:";
			this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialSingleLineTextField1.Hint = "";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(219, 23);
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(773, 23);
			this.materialSingleLineTextField1.TabIndex = 2;
			this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// materialSingleLineTextField2
			// 
			this.materialSingleLineTextField2.Depth = 0;
			this.materialSingleLineTextField2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialSingleLineTextField2.Hint = "";
			this.materialSingleLineTextField2.Location = new System.Drawing.Point(219, 81);
			this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
			this.materialSingleLineTextField2.PasswordChar = '\0';
			this.materialSingleLineTextField2.SelectedText = "";
			this.materialSingleLineTextField2.SelectionLength = 0;
			this.materialSingleLineTextField2.SelectionStart = 0;
			this.materialSingleLineTextField2.Size = new System.Drawing.Size(773, 23);
			this.materialSingleLineTextField2.TabIndex = 3;
			this.materialSingleLineTextField2.Text = "materialSingleLineTextField2";
			this.materialSingleLineTextField2.UseSystemPasswordChar = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(23, 136);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(190, 60);
			this.materialLabel3.TabIndex = 4;
			this.materialLabel3.Text = "New Password:";
			this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialSingleLineTextField3
			// 
			this.materialSingleLineTextField3.Depth = 0;
			this.materialSingleLineTextField3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialSingleLineTextField3.Hint = "";
			this.materialSingleLineTextField3.Location = new System.Drawing.Point(219, 139);
			this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
			this.materialSingleLineTextField3.PasswordChar = '\0';
			this.materialSingleLineTextField3.SelectedText = "";
			this.materialSingleLineTextField3.SelectionLength = 0;
			this.materialSingleLineTextField3.SelectionStart = 0;
			this.materialSingleLineTextField3.Size = new System.Drawing.Size(773, 23);
			this.materialSingleLineTextField3.TabIndex = 5;
			this.materialSingleLineTextField3.Text = "materialSingleLineTextField3";
			this.materialSingleLineTextField3.UseSystemPasswordChar = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
			this.tableLayoutPanel2.Controls.Add(this.materialLabel4, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblGender, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.materialLabel6, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.metroDateTime1, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 199);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(969, 78);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// materialLabel4
			// 
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(3, 0);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(187, 78);
			this.materialLabel4.TabIndex = 0;
			this.materialLabel4.Text = "Gender:";
			this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblGender
			// 
			this.lblGender.Depth = 0;
			this.lblGender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblGender.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblGender.Location = new System.Drawing.Point(196, 0);
			this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(187, 78);
			this.lblGender.TabIndex = 1;
			this.lblGender.Text = "Male";
			this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// materialLabel6
			// 
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(389, 0);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(207, 78);
			this.materialLabel6.TabIndex = 2;
			this.materialLabel6.Text = "Day of Birth:";
			this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroDateTime1
			// 
			this.metroDateTime1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
			this.metroDateTime1.Location = new System.Drawing.Point(602, 3);
			this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
			this.metroDateTime1.Name = "metroDateTime1";
			this.metroDateTime1.Size = new System.Drawing.Size(364, 29);
			this.metroDateTime1.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.materialRaisedButton1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(216, 280);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 66);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// materialRaisedButton1
			// 
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.Location = new System.Drawing.Point(547, 10);
			this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(10);
			this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton1.Name = "materialRaisedButton1";
			this.materialRaisedButton1.Primary = true;
			this.materialRaisedButton1.Size = new System.Drawing.Size(222, 43);
			this.materialRaisedButton1.TabIndex = 0;
			this.materialRaisedButton1.Text = "Update Info";
			this.materialRaisedButton1.UseVisualStyleBackColor = true;
			// 
			// tsMainTab
			// 
			this.tsMainTab.BaseTabControl = this.tcMainTabControl;
			this.tsMainTab.Depth = 0;
			this.tsMainTab.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tsMainTab.Location = new System.Drawing.Point(0, 466);
			this.tsMainTab.MouseState = MaterialSkin.MouseState.HOVER;
			this.tsMainTab.Name = "tsMainTab";
			this.tsMainTab.Size = new System.Drawing.Size(1031, 34);
			this.tsMainTab.TabIndex = 1;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(192, 74);
			this.tabPage4.TabIndex = 0;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(192, 74);
			this.tabPage5.TabIndex = 1;
			this.tabPage5.Text = "tabPage5";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// lblTabName
			// 
			this.lblTabName.BackColor = System.Drawing.Color.Transparent;
			this.lblTabName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTabName.ForeColor = System.Drawing.Color.White;
			this.lblTabName.Location = new System.Drawing.Point(4, 0);
			this.lblTabName.Name = "lblTabName";
			this.lblTabName.Size = new System.Drawing.Size(70, 20);
			this.lblTabName.TabIndex = 2;
			this.lblTabName.Text = "Explore";
			// 
			// lblFullname
			// 
			this.lblFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFullname.BackColor = System.Drawing.Color.Transparent;
			this.lblFullname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFullname.ForeColor = System.Drawing.Color.White;
			this.lblFullname.Location = new System.Drawing.Point(790, 25);
			this.lblFullname.Name = "lblFullname";
			this.lblFullname.Size = new System.Drawing.Size(240, 37);
			this.lblFullname.TabIndex = 3;
			this.lblFullname.Text = "Duong Thanh Dung";
			this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 500);
			this.Controls.Add(this.lblFullname);
			this.Controls.Add(this.lblTabName);
			this.Controls.Add(this.tsMainTab);
			this.Controls.Add(this.tcMainTabControl);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MusicList";
			this.tcMainTabControl.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
