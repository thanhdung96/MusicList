using System;
using MaterialSkin.Controls;

namespace CustomControls
{
	public partial class CustomFlatButton : MaterialFlatButton
	{
		
		public int Id {
			get;
			set;
		}
		
		public CustomFlatButton()
		{
			InitializeComponent();
			this.Id=0;
		}
	}
}
