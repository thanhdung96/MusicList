using System;
using System.Windows.Forms;

namespace CustomControls
{
	public partial class CustomMusicItem : UserControl
	{
		public event EventHandler MusicNameClick, ArtitstNameClick;
		private String component;
		public String Component {
			get{ return this.component; }
			set { this.component = value; }
		}
		
		public CustomMusicItem()
		{
			InitializeComponent();
		}
		
		void LblMusicNameClick(object sender, EventArgs e)
		{
			this.component = "Music Name";
			if(MusicNameClick != null){
				MusicNameClick(this, e);
			}
		}
		void LblSingerClick(object sender, EventArgs e)
		{
			this.component = "Singer Name";
			if(ArtitstNameClick != null){
				ArtitstNameClick(this, e);
			}
		}
	}
}
