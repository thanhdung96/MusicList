namespace CustomControls
{
	partial class CustomCheckbox
	{
		private System.ComponentModel.IContainer components = null;
		private volatile System.Windows.Forms.PictureBox ptbIcon;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.ptbIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// ptbIcon
			// 
			this.ptbIcon.Dock = System.Windows.Forms.DockStyle.Top;
			this.ptbIcon.Location = new System.Drawing.Point(0, 0);
			this.ptbIcon.Margin = new System.Windows.Forms.Padding(0);
			this.ptbIcon.MaximumSize = new System.Drawing.Size(32, 32);
			this.ptbIcon.Name = "ptbIcon";
			this.ptbIcon.Size = new System.Drawing.Size(32, 32);
			this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ptbIcon.TabIndex = 0;
			this.ptbIcon.TabStop = false;
			this.ptbIcon.Click += new System.EventHandler(this.PtbIconClick);
			// 
			// CustomCheckbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.ptbIcon);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(32, 32);
			this.Name = "CustomCheckbox";
			this.Size = new System.Drawing.Size(32, 32);
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
