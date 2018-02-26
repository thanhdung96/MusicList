using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;
using System.Windows.Forms;
using CustomControls;

namespace MusicList
{
	public partial class MainForm : MaterialForm
	{
		public MainForm()
		{
			InitializeComponent();
			
			InitTheme();
			this.tcMainTabControl.SelectedIndexChanged += tcMainTabControl_SelectedIndexChanged;
		}

		void tcMainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int tabindex = this.tcMainTabControl.SelectedIndex;
			Thread thread = new Thread(new ParameterizedThreadStart(EditLableText));
			thread.Start(tabindex);
		}
		
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
		private void InitTheme()
		{
			MaterialSkinManager manager = MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.DARK;
			manager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
			manager.Theme = MaterialSkinManager.Themes.LIGHT;
			
			Thread thread = new Thread(new ParameterizedThreadStart(EditLableText));
			thread.Start(0);
			
			for(int i=0;i<5;i++){
				CustomFlatButton custom = new CustomFlatButton();
				custom.Id = i;
				custom.Dock = DockStyle.Top;
				custom.Text=i.ToString();
				pnlPlaylistContent.Controls.Add(custom);
			}
		}
	}
}
