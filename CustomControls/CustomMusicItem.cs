using System;
using System.Windows.Forms;
using MusicListLibrary.Models;

namespace CustomControls
{
	public partial class CustomMusicItem : UserControl
	{
		public event EventHandler MusicNameClick, ArtitstNameClick;
		
		public CustomMusicItem(Musics music)
		{
			InitializeComponent();
			this.lblMusicName.Text=music.SongName.ToString();
			this.lblSinger.Text=music.Singers.ToString();
			this.lblListens.Text=music.Listens.ToString();
		}
		
		void LblMusicNameClick(object sender, EventArgs e)
		{
			if(MusicNameClick != null){
				MusicNameClick(this, e);
			}
		}
		void LblSingerClick(object sender, EventArgs e)
		{
			if(ArtitstNameClick != null){
				ArtitstNameClick(this, e);
			}
		}
	}
}
