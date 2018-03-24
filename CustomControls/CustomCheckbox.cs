using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Threading;
using System.Windows.Forms;

namespace CustomControls
{
	public partial class CustomCheckbox : UserControl
	{
		public event EventHandler ptbIconClick;
		public enum Functions
		{
			Shuffle,
			Repeat
		}

		[Browsable(true), DefaultValue("Shuffle"), Description("Defines icon for CustomCheckbox by function")]
		[ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
		private Functions func;
		public Functions Function{ 
			get{
				return this.func;
			}
			set{
				this.func = value;
				FunctionChangedCallback();
			}
		}
		
		private bool status;
		public bool Checked { 
			get {
				return status;
			}
			set {
				StatusChangedCallback(value);
				status = value;
			}
		}
		
		public CustomCheckbox()
		{
			InitializeComponent();
			this.Checked = false;
		}
		private void FunctionChangedCallback(){
			this.ptbIcon.Image = this.Function == Functions.Repeat ? resrouce.repeat_inactive : resrouce.shuffle_inactive;
		}
		
		void StatusChangedCallback(bool newValue)
		{
			//if new status if different from current status
			if (this.status != newValue) {
				Thread updateIconThread = new Thread(new ParameterizedThreadStart(UpdateIconCallback));
				updateIconThread.Start(newValue as object);
			}
		}
		
		async void UpdateIconCallback(object newValue)
		{
			this.ptbIcon.Height = 0;
			if (this.Function == Functions.Shuffle) {
				if ((bool)newValue) {
					this.ptbIcon.Image = resrouce.shuffle_active;
				} else
					this.ptbIcon.Image = resrouce.shuffle_inactive;
			} else {
				if ((bool)newValue) {
					this.ptbIcon.Image = resrouce.repeat_active;
				} else
					this.ptbIcon.Image = resrouce.repeat_inactive;
			}
			Thread.Sleep(100);
			for (int i = 1; i <= 16; i++){
				this.ptbIcon.Height += 2;
				Thread.Sleep(1);
			}
		}
		void PtbIconClick(object sender, EventArgs e)
		{
			this.Checked = !this.Checked;
			if (ptbIconClick != null) {
				ptbIconClick(this, e);
			}
		}
	}
}
