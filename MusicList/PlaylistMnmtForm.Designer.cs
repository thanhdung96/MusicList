/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Mar.08.2018
 * Time: 14:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MusicList
{
	partial class PlaylistMnmtForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
		private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
		private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistMnmtForm));
			this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
			this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
			this.SuspendLayout();
			// 
			// bunifuCircleProgressbar1
			// 
			this.bunifuCircleProgressbar1.animated = false;
			this.bunifuCircleProgressbar1.animationIterval = 5;
			this.bunifuCircleProgressbar1.animationSpeed = 300;
			this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.DimGray;
			this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
			this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar1.LabelVisible = true;
			this.bunifuCircleProgressbar1.LineProgressThickness = 8;
			this.bunifuCircleProgressbar1.LineThickness = 5;
			this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(212, 108);
			this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Maroon;
			this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.LawnGreen;
			this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(173, 173);
			this.bunifuCircleProgressbar1.TabIndex = 0;
			this.bunifuCircleProgressbar1.Value = 40;
			// 
			// bunifuGauge1
			// 
			this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
			this.bunifuGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.bunifuGauge1.Location = new System.Drawing.Point(491, 85);
			this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuGauge1.Name = "bunifuGauge1";
			this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray;
			this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen;
			this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato;
			this.bunifuGauge1.Size = new System.Drawing.Size(174, 117);
			this.bunifuGauge1.TabIndex = 1;
			this.bunifuGauge1.Thickness = 20;
			this.bunifuGauge1.Value = 40;
			// 
			// bunifuTextbox1
			// 
			this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
			this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
			this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
			this.bunifuTextbox1.Location = new System.Drawing.Point(466, 222);
			this.bunifuTextbox1.Name = "bunifuTextbox1";
			this.bunifuTextbox1.Size = new System.Drawing.Size(250, 42);
			this.bunifuTextbox1.TabIndex = 2;
			this.bunifuTextbox1.text = "Bunifu TextBox";
			// 
			// PlaylistMnmtForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 314);
			this.Controls.Add(this.bunifuTextbox1);
			this.Controls.Add(this.bunifuGauge1);
			this.Controls.Add(this.bunifuCircleProgressbar1);
			this.Name = "PlaylistMnmtForm";
			this.Text = "PlaylistMnmtForm";
			this.ResumeLayout(false);

		}
	}
}
