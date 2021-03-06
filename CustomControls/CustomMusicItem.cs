﻿using System;
using System.Windows.Forms;
using MusicListLibrary.Models;
using System.Drawing;
namespace CustomControls
{
	public partial class CustomMusicItem : UserControl
	{
		public Musics Music{ get; private set; }
		public string Singer{ get; private set; } 
		public event EventHandler MusicNameClick, ArtitstNameClick;
		
		public CustomMusicItem(Musics music)
		{
			InitializeComponent();
			this.Music = music;
			this.lblMusicName.Text=music.SongName.ToString();
			foreach (String singer in this.Music.Singers) {
				Label lblSinger = new Label {
					Dock = DockStyle.Left,
					Text = singer,
					Font = new Font("Roboto", 9F),
					AutoSize = true,
					Margin = new Padding(0, 15, 5, 0),
				};
				
				lblSinger.Click += LblSingerClick;
				lblSinger.MouseHover += lblSinger_MouseHover;
				lblSinger.MouseLeave += lblSinger_MouseLeave;
				pnlSingers.Controls.Add(lblSinger);
			}
			//this.lblSinger.Text=music.Singers.ToString();
			this.lblListens.Text = String.Format("{0:n0}",music.Listens.ToInt32());
		}
		
		void LblMusicNameClick(object sender, EventArgs e)
		{
			if (MusicNameClick != null) {
				MusicNameClick(this, e);
			}
		}
		void LblSingerClick(object sender, EventArgs e)
		{
			this.Singer = (sender as Label).Text;
			if (ArtitstNameClick != null) {
				ArtitstNameClick(this, e);
			}
		}

		void lblSinger_MouseHover(object sender, EventArgs e)
		{
			((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Bold);
		}
		void lblSinger_MouseLeave(object sender, EventArgs e)
		{
			((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
		}
		
		void LblMusicNameMouseEnter(object sender, EventArgs e)
		{
			((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Bold);
		}
		void LblMusicNameMouseLeave(object sender, EventArgs e)
		{
			((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
		}
	}
}
