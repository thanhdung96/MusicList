using System;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace CustomControls
{
	public partial class CustomCheckbox : UserControl
	{
		public event EventHandler ptbIconClick;

		public enum functions
		{
			Shuffle,
			Repeat
		}
		[Browsable(true), DefaultValue("Shuffle"), Description("Defines icon for CustomCheckbox by function")]
		[ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
		public functions Function{ get; set; }
		
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
			ptbIcon.Image = resrouce.shuffle_inactive;
		}
		
		
		private void StatusChangedCallback(bool newValue)
		{
			//if new status if different from current status
			if (this.status != newValue) {
				Thread updateIconThread = new Thread(new ParameterizedThreadStart(UpdateIconCallback));
				updateIconThread.Start(newValue as object);
			}
		}
		
		private async void UpdateIconCallback(object newValue)
		{
			this.ptbIcon.Height = 0;
			if (this.Function == functions.Shuffle) {
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
			for (int i = 1; i <= 16; i++){
				this.ptbIcon.Height += 4;
				Thread.Sleep(1);
			}
			MessageBox.Show(this.ptbIcon.Height.ToString());
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
