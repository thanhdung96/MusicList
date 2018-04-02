using System;
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
using Bunifu.Framework.UI;

namespace MusicList
{
	public partial class MainForm : MaterialForm
	{
		public static volatile Users session;
		private MusicCrawler crawler;
		private List<Musics> IndexMusics;
		private List<BunifuThinButton2> lsPages;

		public MainForm()
		{
			InitializeComponent();
			IndexMusics = new List<Musics>();
			lsPages = new List<BunifuThinButton2>();
			this.cbxFindBy.SelectedIndex = 0;
			
			InitTheme();
			this.tcMainTabControl.SelectedIndexChanged += tcMainTabControl_SelectedIndexChanged;
		}

		#region Functions
		private void AddMusicItems()
		{
			this.pnlMusicItemsList.Controls.Clear();
			foreach (Musics music in IndexMusics) {
				CustomMusicItem custom = new CustomMusicItem(music);
				custom.Dock = DockStyle.Top;
				this.pnlMusicItemsList.Controls.Add(custom);
				custom.MusicNameClick += custom_MusicNameClick;
				custom.ArtitstNameClick += custom_ArtitstNameClick;
			}
		}
		private static List<Color> RgbLinearInterpolate(Color start, Color end, int colorCount)
		{
			List<Color> ret = new List<Color>();

			// linear interpolation lerp (r,a,b) = (1-r)*a + r*b = (1-r)*(ax,ay,az) + r*(bx,by,bz)
			for (int n = 0; n < colorCount; n++) {
				double r = (double)n / (double)(colorCount - 1);
				double nr = 1.0 - r;
				double A = (nr * start.A) + (r * end.A);
				double R = (nr * start.R) + (r * end.R);
				double G = (nr * start.G) + (r * end.G);
				double B = (nr * start.B) + (r * end.B);

				ret.Add(Color.FromArgb((byte)A, (byte)R, (byte)G, (byte)B));
			}

			return ret;
		}
		private void InitTheme()
		{
			for (int i = 5; i >= 1; i--) {
				BunifuThinButton2 button = new BunifuThinButton2 {
					ButtonText = i.ToString(),
					Dock = DockStyle.Left,
					ActiveFillColor = Color.FromArgb(255, 0, 40, 77),
					ActiveLineColor = Color.FromArgb(255, 0, 40, 77),
					ActiveForecolor = Color.White,
					IdleFillColor = Color.White,
					IdleLineColor = Color.FromArgb(255, 0, 40, 77),
					IdleForecolor = Color.FromArgb(255, 0, 40, 77),
					TextAlign = ContentAlignment.MiddleCenter,
					Width = 40,
					Height = 29
				};
				button.Click += button_Click;
				lsPages.Add(button);
				pnlPages.Controls.Add(button);
			}
			lsPages[lsPages.Count - 1].Font = new Font(lsPages[3].Font, FontStyle.Bold);
			
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
				
				this.pnlMusicItemsList.Visible = false;
				this.AddMusicItems();
				this.pnlMusicItemsList.Visible = true;
				this.Cursor = Cursors.Arrow;
				
				UpdateInfoLogin();
			}
		}

		void custom_MusicNameClick(object sender, EventArgs e)
		{
			//TODO: implement play music here
			MessageBox.Show(((CustomMusicItem)sender).MusicURL);
			MessageBox.Show(((CustomMusicItem)sender).MusicId);
		}

		void custom_ArtitstNameClick(object sender, EventArgs e)
		{
			//TODO: implement find by singer here
			this.txtFind.Text = ((CustomMusicItem)sender).SingerName;
			this.GetMusicsBySinger(this.txtFind.Text);
			this.AddMusicItems();
		}

		void button_Click(object sender, EventArgs e)
		{
			BunifuThinButton2 clickedButton = ((BunifuThinButton2)sender);
			if (clickedButton.Font.Style == FontStyle.Regular) {
				if (!string.IsNullOrEmpty(this.txtFind.Text)) {		//if find query is not empty
					if (this.cbxFindBy.SelectedIndex == 0) {		//if finding singer
						GetMusicsBySinger(this.txtFind.Text, Convert.ToInt32(clickedButton.ButtonText));
						this.AddMusicItems();
					}
				} else {
					GetIndexMusics(Convert.ToInt32(clickedButton.ButtonText));
					this.AddMusicItems();
				}
			}
			foreach (BunifuThinButton2 button in this.lsPages) {
				button.Font = new Font(button.Font, FontStyle.Regular);
			}
			clickedButton.Font = new Font(clickedButton.Font, FontStyle.Bold);
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

		async void LblFindClick(object sender, EventArgs e)
		{
			if (this.txtFind.Width > 0) {
				if (this.txtFind.Text.Length == 0) {
					Thread t = new Thread(new ParameterizedThreadStart(EditTxtFind));
					t.Start(false as object);
					this.cbxFindBy.Visible = false;
					this.lblFindBy.Visible = false;
				} else {
					if (this.cbxFindBy.SelectedIndex == 0) {
						await Task.Run(() => GetMusicsBySinger(this.txtFind.Text));
						this.AddMusicItems();
					}
				}
			} else {
				Thread t = new Thread(new ParameterizedThreadStart(EditTxtFind));
				t.Start(true as object);
				this.cbxFindBy.Visible = true;
				this.lblFindBy.Visible = true;
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
			int value = (bool)expend ? 30 : -30;
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
			List<Color> change = RgbLinearInterpolate(Color.FromArgb(0, 55, 71, 79), Color.White, 20);
			foreach (Color color in change) {
				lblFullname.ForeColor = color;
				Thread.Sleep(20);
			}
		}
		
		private void GetMusicsBySinger(string singer, int page = 1)
		{
			crawler = new MusicCrawler();
			IndexMusics = crawler.GetMusicsBySinger(singer, page).ToList();
		}
		private void GetIndexMusics(int page = 1)
		{
			crawler = new MusicCrawler();
			IndexMusics = crawler.GetIndex(page).ToList();
		}
		#endregion Threading
	}
}
