using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;
using System.Windows.Forms;
using CustomControls;
using MusicListLibrary.Models;

namespace MusicList
{
	public partial class MainForm : MaterialForm
	{
		private static Users session;
		
		public MainForm()
		{
			InitializeComponent();
			
			InitTheme();
			this.tcMainTabControl.SelectedIndexChanged += tcMainTabControl_SelectedIndexChanged;
			
			if (MainForm.session == null) {
				LoginForm login = new LoginForm();
				login.ShowInTaskbar = false;
				login.ShowDialog(this);
			}
		}

		void tcMainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int tabindex = this.tcMainTabControl.SelectedIndex;
			Thread thread = new Thread(new ParameterizedThreadStart(EditLableText));
			thread.Start(tabindex);
		}

		void musicitem_ArtitstNameClick(object sender, EventArgs e)
		{
			CustomMusicItem item = sender as CustomMusicItem;
			MessageBox.Show(item.Component);
		}

		void musicitem_MusicNameClick(object sender, EventArgs e)
		{
			CustomMusicItem item = sender as CustomMusicItem;
			MessageBox.Show(item.Component);
		}

		private void InitTheme()
		{
			MaterialSkinManager manager = MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.DARK;
			manager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
			manager.Theme = MaterialSkinManager.Themes.LIGHT;
			
			Thread thread = new Thread(new ParameterizedThreadStart(EditLableText));
			thread.Start(0);
			
			for (int i = 0; i < 5; i++) {
				CustomFlatButton custom = new CustomFlatButton();
				custom.Id = i;
				custom.Dock = DockStyle.Top;
				custom.Text = i.ToString();
				custom.Click += custom_Click;
				pnlPlaylistContent.Controls.Add(custom);
				
				CustomMusicItem musicitem = new CustomMusicItem();
				musicitem.Dock = DockStyle.Top;
				musicitem.ArtitstNameClick += musicitem_ArtitstNameClick;
				musicitem.MusicNameClick += musicitem_MusicNameClick;
				pnlMusicItemsList.Controls.Add(musicitem);
			}
		}

		void custom_Click(object sender, EventArgs e)
		{
			CustomFlatButton custom = sender as CustomFlatButton;
			CustomMessageBox.Show("Id: " + custom.Id.ToString(), custom.Text, CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
		}
		
		void BtnShowPlaylistsClick(object sender, EventArgs e)
		{
			PlaylistMnmtForm pl = new PlaylistMnmtForm();
			pl.ShowInTaskbar=false;
			pl.ShowDialog(this);
		}

		void LblFindClick(object sender, EventArgs e)
		{
			if (this.txtFind.Width > 0) {
				if (this.txtFind.Text.Length == 0) {
					Thread t = new Thread(new ParameterizedThreadStart(EditTxtFind));
					t.Start(false as object);
				} else {
					CustomMessageBox.Show(this.txtFind.Text, "Find", CustomMessageBox.Buttons.OK, CustomMessageBox.Icon.Info, CustomMessageBox.AnimateStyle.FadeIn);
				}
			} else {
				Thread t = new Thread(new ParameterizedThreadStart(EditTxtFind));
				t.Start(true as object);
			}
		}
		
		#region Threading
		private void EditLableText(object tabindex)
		{
			int index = (int)tabindex;
			this.lblTabName.Width = 0;
			switch (index) {
				case 0:
					this.lblTabName.Text = "Explore";
					break;
				case 1:
					this.lblTabName.Text = "Playlist";
					break;
				default:
					this.lblTabName.Text = "Account";
					break;
			}
			for (int i = 0; i < 35; i++) {
				this.lblTabName.Width += 2;
				Thread.Sleep(1);
			}
		}
		private void EditTxtFind(object expend)
		{
			int value = (bool)expend == true ? 30 : -30;
			for (int i = 0; i < 16; i++) {
				txtFind.Width += value;
				Thread.Sleep(1);
			}
		}
		void TxtFindLeave(object sender, EventArgs e)
		{
			Thread t = new Thread(new ParameterizedThreadStart(EditTxtFind));
			t.Start(false as object);
		}
		#endregion Threading
	}
}
