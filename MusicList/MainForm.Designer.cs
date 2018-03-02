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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel pnlMusicVisual;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label pnlPlaylistName;
		private MaterialSkin.Controls.MaterialFlatButton btnShowPlaylists;
		private System.Windows.Forms.Panel pnlPlaylistContent;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
		private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private MaterialSkin.Controls.MaterialLabel lblFind;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtFind;
		private MetroFramework.Controls.MetroComboBox cbxCategories;
		
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
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.lblFind = new MaterialSkin.Controls.MaterialLabel();
			this.txtFind = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.cbxCategories = new MetroFramework.Controls.MetroComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.pnlMusicVisual = new System.Windows.Forms.Panel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.pnlPlaylistName = new System.Windows.Forms.Label();
			this.btnShowPlaylists = new MaterialSkin.Controls.MaterialFlatButton();
			this.pnlPlaylistContent = new System.Windows.Forms.Panel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
			this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
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
			this.tabpage1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMainTabControl
			// 
			this.tcMainTabControl.Controls.Add(this.tabpage1);
			this.tcMainTabControl.Controls.Add(this.tabPage2);
			this.tcMainTabControl.Controls.Add(this.tabPage3);
			this.tcMainTabControl.Depth = 0;
			this.tcMainTabControl.Location = new System.Drawing.Point(0, 64);
			this.tcMainTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.tcMainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.tcMainTabControl.Name = "tcMainTabControl";
			this.tcMainTabControl.SelectedIndex = 0;
			this.tcMainTabControl.Size = new System.Drawing.Size(1032, 400);
			this.tcMainTabControl.TabIndex = 0;
			// 
			// tabpage1
			// 
			this.tabpage1.BackColor = System.Drawing.Color.White;
			this.tabpage1.Controls.Add(this.tableLayoutPanel6);
			this.tabpage1.Location = new System.Drawing.Point(4, 22);
			this.tabpage1.Name = "tabpage1";
			this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabpage1.Size = new System.Drawing.Size(1024, 374);
			this.tabpage1.TabIndex = 0;
			this.tabpage1.Text = "Explore";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.57171F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.42829F));
			this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 3;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 295F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1018, 368);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel6.SetColumnSpan(this.tableLayoutPanel7, 2);
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 493F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel7.Controls.Add(this.lblFind, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.txtFind, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.cbxCategories, 2, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(1018, 34);
			this.tableLayoutPanel7.TabIndex = 0;
			// 
			// lblFind
			// 
			this.lblFind.Depth = 0;
			this.lblFind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblFind.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblFind.Image = global::MusicList.resource.searching_magnifying_glass;
			this.lblFind.Location = new System.Drawing.Point(0, 0);
			this.lblFind.Margin = new System.Windows.Forms.Padding(0);
			this.lblFind.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblFind.Name = "lblFind";
			this.lblFind.Size = new System.Drawing.Size(32, 34);
			this.lblFind.TabIndex = 1;
			this.lblFind.Click += new System.EventHandler(this.LblFindClick);
			// 
			// txtFind
			// 
			this.txtFind.Depth = 0;
			this.txtFind.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtFind.Hint = "Find";
			this.txtFind.Location = new System.Drawing.Point(52, 3);
			this.txtFind.Margin = new System.Windows.Forms.Padding(20, 3, 0, 3);
			this.txtFind.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtFind.Name = "txtFind";
			this.txtFind.PasswordChar = '\0';
			this.txtFind.SelectedText = "";
			this.txtFind.SelectionLength = 0;
			this.txtFind.SelectionStart = 0;
			this.txtFind.Size = new System.Drawing.Size(0, 23);
			this.txtFind.TabIndex = 2;
			this.txtFind.UseSystemPasswordChar = false;
			this.txtFind.Leave += new System.EventHandler(this.TxtFindLeave);
			// 
			// cbxCategories
			// 
			this.cbxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbxCategories.FormattingEnabled = true;
			this.cbxCategories.ItemHeight = 23;
			this.cbxCategories.Location = new System.Drawing.Point(575, 0);
			this.cbxCategories.Margin = new System.Windows.Forms.Padding(50, 0, 200, 0);
			this.cbxCategories.Name = "cbxCategories";
			this.cbxCategories.Size = new System.Drawing.Size(243, 29);
			this.cbxCategories.TabIndex = 3;
			this.cbxCategories.UseSelectable = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1024, 374);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Playlists";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel3.Controls.Add(this.pnlMusicVisual, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.97861F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.02139F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1024, 374);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// pnlMusicVisual
			// 
			this.pnlMusicVisual.BackColor = System.Drawing.Color.DarkGray;
			this.pnlMusicVisual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMusicVisual.Location = new System.Drawing.Point(0, 0);
			this.pnlMusicVisual.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMusicVisual.Name = "pnlMusicVisual";
			this.pnlMusicVisual.Size = new System.Drawing.Size(716, 343);
			this.pnlMusicVisual.TabIndex = 0;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.pnlPlaylistName, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnShowPlaylists, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.pnlPlaylistContent, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(716, 0);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel3.SetRowSpan(this.tableLayoutPanel4, 2);
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(308, 374);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// pnlPlaylistName
			// 
			this.pnlPlaylistName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPlaylistName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlPlaylistName.Location = new System.Drawing.Point(33, 0);
			this.pnlPlaylistName.Name = "pnlPlaylistName";
			this.pnlPlaylistName.Size = new System.Drawing.Size(272, 30);
			this.pnlPlaylistName.TabIndex = 0;
			this.pnlPlaylistName.Text = "<Playlist Name>";
			this.pnlPlaylistName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnShowPlaylists
			// 
			this.btnShowPlaylists.AutoSize = true;
			this.btnShowPlaylists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnShowPlaylists.Depth = 0;
			this.btnShowPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnShowPlaylists.Location = new System.Drawing.Point(0, 0);
			this.btnShowPlaylists.Margin = new System.Windows.Forms.Padding(0);
			this.btnShowPlaylists.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnShowPlaylists.Name = "btnShowPlaylists";
			this.btnShowPlaylists.Primary = false;
			this.btnShowPlaylists.Size = new System.Drawing.Size(30, 30);
			this.btnShowPlaylists.TabIndex = 1;
			this.btnShowPlaylists.Text = "<";
			this.btnShowPlaylists.UseVisualStyleBackColor = true;
			// 
			// pnlPlaylistContent
			// 
			this.tableLayoutPanel4.SetColumnSpan(this.pnlPlaylistContent, 2);
			this.pnlPlaylistContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPlaylistContent.Location = new System.Drawing.Point(0, 30);
			this.pnlPlaylistContent.Margin = new System.Windows.Forms.Padding(0);
			this.pnlPlaylistContent.Name = "pnlPlaylistContent";
			this.pnlPlaylistContent.Size = new System.Drawing.Size(308, 344);
			this.pnlPlaylistContent.TabIndex = 2;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 6;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.materialRaisedButton2, 4, 0);
			this.tableLayoutPanel5.Controls.Add(this.materialRaisedButton3, 3, 0);
			this.tableLayoutPanel5.Controls.Add(this.materialRaisedButton4, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.metroTrackBar1, 5, 0);
			this.tableLayoutPanel5.Controls.Add(this.materialCheckBox1, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.materialCheckBox2, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 343);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(716, 31);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// materialRaisedButton2
			// 
			this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.materialRaisedButton2.Depth = 0;
			this.materialRaisedButton2.Location = new System.Drawing.Point(372, 1);
			this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
			this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton2.Name = "materialRaisedButton2";
			this.materialRaisedButton2.Primary = true;
			this.materialRaisedButton2.Size = new System.Drawing.Size(29, 29);
			this.materialRaisedButton2.TabIndex = 0;
			this.materialRaisedButton2.Text = ">>";
			this.materialRaisedButton2.UseVisualStyleBackColor = true;
			// 
			// materialRaisedButton3
			// 
			this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.materialRaisedButton3.Depth = 0;
			this.materialRaisedButton3.Location = new System.Drawing.Point(342, 1);
			this.materialRaisedButton3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton3.Name = "materialRaisedButton3";
			this.materialRaisedButton3.Primary = true;
			this.materialRaisedButton3.Size = new System.Drawing.Size(30, 29);
			this.materialRaisedButton3.TabIndex = 1;
			this.materialRaisedButton3.Text = "||";
			this.materialRaisedButton3.UseVisualStyleBackColor = true;
			// 
			// materialRaisedButton4
			// 
			this.materialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.materialRaisedButton4.Depth = 0;
			this.materialRaisedButton4.Location = new System.Drawing.Point(313, 1);
			this.materialRaisedButton4.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
			this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton4.Name = "materialRaisedButton4";
			this.materialRaisedButton4.Primary = true;
			this.materialRaisedButton4.Size = new System.Drawing.Size(29, 29);
			this.materialRaisedButton4.TabIndex = 2;
			this.materialRaisedButton4.Text = "<<";
			this.materialRaisedButton4.UseVisualStyleBackColor = true;
			// 
			// metroTrackBar1
			// 
			this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
			this.metroTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTrackBar1.Location = new System.Drawing.Point(412, 0);
			this.metroTrackBar1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.metroTrackBar1.Name = "metroTrackBar1";
			this.metroTrackBar1.Size = new System.Drawing.Size(294, 31);
			this.metroTrackBar1.TabIndex = 3;
			this.metroTrackBar1.Text = "metroTrackBar1";
			this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// materialCheckBox1
			// 
			this.materialCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.materialCheckBox1.Depth = 0;
			this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox1.Location = new System.Drawing.Point(156, 0);
			this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox1.MouseLocation = new System.Drawing.Point(0, 0);
			this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox1.Name = "materialCheckBox1";
			this.materialCheckBox1.Ripple = true;
			this.materialCheckBox1.Size = new System.Drawing.Size(31, 31);
			this.materialCheckBox1.TabIndex = 4;
			this.materialCheckBox1.UseVisualStyleBackColor = true;
			// 
			// materialCheckBox2
			// 
			this.materialCheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.materialCheckBox2.Depth = 0;
			this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox2.Location = new System.Drawing.Point(125, 0);
			this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox2.MouseLocation = new System.Drawing.Point(0, 0);
			this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox2.Name = "materialCheckBox2";
			this.materialCheckBox2.Ripple = true;
			this.materialCheckBox2.Size = new System.Drawing.Size(31, 31);
			this.materialCheckBox2.TabIndex = 5;
			this.materialCheckBox2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tableLayoutPanel1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1024, 374);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Account";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.94867F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.05134F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 368);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(23, 30);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(230, 60);
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
			this.materialLabel2.Location = new System.Drawing.Point(23, 90);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(230, 60);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Email:";
			this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialSingleLineTextField1.Hint = "Fullname";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(259, 50);
			this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(3, 20, 200, 3);
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(508, 23);
			this.materialSingleLineTextField1.TabIndex = 2;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// materialSingleLineTextField2
			// 
			this.materialSingleLineTextField2.Depth = 0;
			this.materialSingleLineTextField2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialSingleLineTextField2.Hint = "Email";
			this.materialSingleLineTextField2.Location = new System.Drawing.Point(259, 110);
			this.materialSingleLineTextField2.Margin = new System.Windows.Forms.Padding(3, 20, 200, 3);
			this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
			this.materialSingleLineTextField2.PasswordChar = '\0';
			this.materialSingleLineTextField2.SelectedText = "";
			this.materialSingleLineTextField2.SelectionLength = 0;
			this.materialSingleLineTextField2.SelectionStart = 0;
			this.materialSingleLineTextField2.Size = new System.Drawing.Size(508, 23);
			this.materialSingleLineTextField2.TabIndex = 3;
			this.materialSingleLineTextField2.UseSystemPasswordChar = false;
			// 
			// materialLabel3
			// 
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(23, 150);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(230, 60);
			this.materialLabel3.TabIndex = 4;
			this.materialLabel3.Text = "New Password:";
			this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// materialSingleLineTextField3
			// 
			this.materialSingleLineTextField3.Depth = 0;
			this.materialSingleLineTextField3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialSingleLineTextField3.Hint = "Change to new password";
			this.materialSingleLineTextField3.Location = new System.Drawing.Point(259, 170);
			this.materialSingleLineTextField3.Margin = new System.Windows.Forms.Padding(3, 20, 200, 3);
			this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
			this.materialSingleLineTextField3.PasswordChar = '\0';
			this.materialSingleLineTextField3.SelectedText = "";
			this.materialSingleLineTextField3.SelectionLength = 0;
			this.materialSingleLineTextField3.SelectionStart = 0;
			this.materialSingleLineTextField3.Size = new System.Drawing.Size(508, 23);
			this.materialSingleLineTextField3.TabIndex = 5;
			this.materialSingleLineTextField3.UseSystemPasswordChar = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.87457F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22067F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41638F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.406F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel2.Controls.Add(this.materialLabel4, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblGender, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.materialLabel6, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.metroDateTime1, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 213);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(941, 78);
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
			this.materialLabel4.Size = new System.Drawing.Size(211, 78);
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
			this.lblGender.Location = new System.Drawing.Point(220, 0);
			this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(73, 78);
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
			this.materialLabel6.Location = new System.Drawing.Point(299, 0);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(130, 78);
			this.materialLabel6.TabIndex = 2;
			this.materialLabel6.Text = "Day of Birth:";
			this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroDateTime1
			// 
			this.metroDateTime1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroDateTime1.Enabled = false;
			this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
			this.metroDateTime1.Location = new System.Drawing.Point(435, 23);
			this.metroDateTime1.Margin = new System.Windows.Forms.Padding(3, 23, 100, 3);
			this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 29);
			this.metroDateTime1.Name = "metroDateTime1";
			this.metroDateTime1.Size = new System.Drawing.Size(244, 29);
			this.metroDateTime1.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.materialRaisedButton1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 294);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 66);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// materialRaisedButton1
			// 
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.Location = new System.Drawing.Point(479, 10);
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
			this.tsMainTab.Location = new System.Drawing.Point(0, 465);
			this.tsMainTab.MouseState = MaterialSkin.MouseState.HOVER;
			this.tsMainTab.Name = "tsMainTab";
			this.tsMainTab.Size = new System.Drawing.Size(1031, 35);
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
			this.lblFullname.Text = "[Fullname]";
			this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 500);
			this.Controls.Add(this.tcMainTabControl);
			this.Controls.Add(this.lblFullname);
			this.Controls.Add(this.lblTabName);
			this.Controls.Add(this.tsMainTab);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MusicList";
			this.tcMainTabControl.ResumeLayout(false);
			this.tabpage1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
