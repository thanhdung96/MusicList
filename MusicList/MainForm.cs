using System;
using MaterialSkin.Controls;
using MaterialSkin;

namespace MusicList
{
	public partial class MainForm : MaterialForm
	{
		public MainForm()
		{
			InitializeComponent();
			
			InitTheme();
		}
		
		private void InitTheme(){
			MaterialSkinManager manager = MaterialSkinManager.Instance;
			manager.AddFormToManage(this);
			manager.Theme = MaterialSkinManager.Themes.DARK;
			manager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}
	}
}
