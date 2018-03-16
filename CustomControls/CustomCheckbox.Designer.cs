/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Mar.15.2018
 * Time: 10:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CustomControls
{
	partial class CustomCheckbox
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel pnlColorBar;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.PictureBox ptbIcon;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pnlColorBar = new System.Windows.Forms.Panel();
			this.lblText = new System.Windows.Forms.Label();
			this.ptbIcon = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pnlColorBar, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblText, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.ptbIcon, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 38);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pnlColorBar
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.pnlColorBar, 2);
			this.pnlColorBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlColorBar.Location = new System.Drawing.Point(0, 28);
			this.pnlColorBar.Margin = new System.Windows.Forms.Padding(0);
			this.pnlColorBar.Name = "pnlColorBar";
			this.pnlColorBar.Size = new System.Drawing.Size(330, 10);
			this.pnlColorBar.TabIndex = 0;
			// 
			// lblText
			// 
			this.lblText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.Location = new System.Drawing.Point(26, 0);
			this.lblText.Margin = new System.Windows.Forms.Padding(0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(100, 23);
			this.lblText.TabIndex = 1;
			this.lblText.Text = "label1";
			// 
			// ptbIcon
			// 
			this.ptbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ptbIcon.Location = new System.Drawing.Point(0, 0);
			this.ptbIcon.Margin = new System.Windows.Forms.Padding(0);
			this.ptbIcon.Name = "ptbIcon";
			this.ptbIcon.Size = new System.Drawing.Size(26, 28);
			this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ptbIcon.TabIndex = 2;
			this.ptbIcon.TabStop = false;
			// 
			// CustomCheckbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "CustomCheckbox";
			this.Size = new System.Drawing.Size(330, 38);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
