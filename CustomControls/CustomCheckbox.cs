using System;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace CustomControls
{
	public partial class CustomCheckbox : UserControl
	{
		public enum functions
		{
			Shuffle,
			Repeat
		}
		[Browsable(true), DefaultValue("Shuffle"), Description("Defines icon for CustomCheckbox by function")]
		[ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
		public functions Function{ get; set; }
		
		public String Text {
			get {
				return this.lblText.Text;
			}
			set {
				this.lblText.Text = value;
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
		public event EventHandler ptbIconClicked;
		
		public CustomCheckbox()
		{
			InitializeComponent();
			this.Checked = false;
			ptbIcon.Image = resrouce.shuffle_inactive;
		}
		
		public void IconClick(object sender, EventArgs e){
			this.status=!this.status;
			if(ptbIconClicked!=null){
				ptbIconClicked(this,e);
			}
		}
		
		private void StatusChangedCallback(bool newValue)
		{
			//if new status if different from current status
			if (this.status != newValue) {
				Thread updateIconThread = new Thread(new ParameterizedThreadStart(UpdateIconCallback));
				Thread updateColorBarThread = new Thread(new ParameterizedThreadStart(UpdateColorbarCallBack));
				updateIconThread.Start(newValue as object);
				updateColorBarThread.Start(newValue as object);
			}
		}
		
		private void UpdateIconCallback(object newValue){
			
		}
		
		private void UpdateColorbarCallBack(object newValue){
			
		}
	}
}
