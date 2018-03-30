﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CustomControls;
using MaterialSkin;
using MaterialSkin.Controls;
using MusicListLibrary.Models;
using WebCrawler;
using System.Windows.Forms;

namespace MusicList
{
	public partial class MainForm : MaterialForm
	{
		public static volatile Users session;
		private List<Musics> IndexMusics;

		public MainForm()
		{
			InitializeComponent();
			IndexMusics = new List<Musics>();
			
			InitTheme();
			this.tcMainTabControl.SelectedIndexChanged += tcMainTabControl_SelectedIndexChanged;
		}

		#region Functions
		private void InitTheme()
		{
			MaterialSkinManager manager = MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.DARK;
			manager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
			manager.Theme = MaterialSkinManager.Themes.LIGHT;
			
			Thread thread = new Thread(new ParameterizedThreadStart(EditLableText));
			thread.Start(0);
		}

		private void UpdateInfoLogin()
		{
			this.txtFullName.Text = MainForm.session.Fullname.ToString();
			this.txtEmail.Text = MainForm.session.Email.ToString();
			this.lblGender.Text = MainForm.session.Gender.ToBoolean() ? "Male" : "Female";
			this.dtpDOB.Value = MainForm.session.DOB.ToLocalTime();
		}
		#endregion Functions
		
		#region Events
		async void MainFormShown(object sender, EventArgs e)
		{
			LoginForm login = new LoginForm();
			login.ShowInTaskbar = false;
			login.ShowDialog(this);
			if (!login.LoginOK)
				this.Dispose(true);
			else {
				Thread t = new Thread(new ThreadStart(LblFullNameChangeLoginOK));
				t.Start();
				
				this.Cursor = Cursors.WaitCursor;
				await Task.Run(() => GetIndexMusics());
				foreach (Musics music in IndexMusics) {
					CustomMusicItem custom = new CustomMusicItem(music);
					custom.Dock = DockStyle.Top;
					this.pnlMusicItemsList.Controls.Add(custom);
				}
				this.Cursor = Cursors.Arrow;
				
				UpdateInfoLogin();
			}
		}

		void tcMainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int tabindex = this.tcMainTabControl.SelectedIndex;
			Thread thread = new Thread(new ParameterizedThreadStart(EditLableText));
			thread.Start(tabindex);
		}

		void BtnUpdateInfoClick(object sender, EventArgs e)
		{
	
		}
		
		void BtnShowPlaylistsClick(object sender, EventArgs e)
		{
			PlaylistMnmtForm pl = new PlaylistMnmtForm();
			pl.ShowInTaskbar = false;
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
		#endregion Events
		
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
		void LblFullNameChangeLoginOK()
		{
			this.lblFullname.Text = MainForm.session.Fullname.ToString();
			for (int i = 0; i < 255; i += 5) {
				this.lblFullname.ForeColor = Color.FromArgb(i, Color.White);
				Thread.Sleep(2);
			}
		}
		
		private async void GetIndexMusics()
		{
			MusicCrawler crawler = new MusicCrawler();
			IndexMusics = crawler.GetIndex().ToList();
		}
		#endregion Threading
	}
}
