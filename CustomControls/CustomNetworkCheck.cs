using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CustomControls
{
	public partial class CustomNetworkCheck : UserControl
	{
		SolidBrush brushAvailable, brushUnavailable;
		public CustomNetworkCheck()
		{
			InitializeComponent();
			brushUnavailable = new SolidBrush(Color.OrangeRed);
			brushAvailable = new SolidBrush(Color.LightGreen);
			StatusTooltip.UseFading = true;
			
			UpdateTimer = new Timer();
			UpdateTimer.Enabled = true;
			UpdateTimer.Tick += UpdateTimer_Tick;
		}

		void UpdateTimer_Tick(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(ptbStatus.Width, ptbStatus.Height);
			using (Graphics graphic = Graphics.FromImage(bitmap)) {
				if (NetworkInterface.GetIsNetworkAvailable()) {
					graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
					graphic.FillEllipse(brushAvailable, 10, 10, 10, 10);
					StatusTooltip.SetToolTip(ptbStatus, "Available");
					
				} else {
					graphic.FillEllipse(brushUnavailable, 10, 10, 10, 10);
					StatusTooltip.SetToolTip(ptbStatus, "Unavailable");
				}
			}
			ptbStatus.Image = bitmap;
		}
	}
}
