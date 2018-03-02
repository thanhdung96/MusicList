/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Mar.02.2018
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CustomControls
{
	partial class CustomMusicItem
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialLabel lblIconMusic;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel lblMusicName;
		private MaterialSkin.Controls.MaterialLabel lblListens;
		private MaterialSkin.Controls.MaterialLabel lblSinger;
		
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.lblMusicName = new MaterialSkin.Controls.MaterialLabel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lblListens = new MaterialSkin.Controls.MaterialLabel();
			this.lblSinger = new MaterialSkin.Controls.MaterialLabel();
			this.lblIconMusic = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 57);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblMusicName, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 28);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Image = global::CustomControls.resrouce.play_arrow;
			this.materialLabel2.Location = new System.Drawing.Point(0, 0);
			this.materialLabel2.Margin = new System.Windows.Forms.Padding(0);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(37, 28);
			this.materialLabel2.TabIndex = 2;
			// 
			// lblMusicName
			// 
			this.lblMusicName.Depth = 0;
			this.lblMusicName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMusicName.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblMusicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblMusicName.Location = new System.Drawing.Point(40, 0);
			this.lblMusicName.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblMusicName.Name = "lblMusicName";
			this.lblMusicName.Size = new System.Drawing.Size(433, 28);
			this.lblMusicName.TabIndex = 3;
			this.lblMusicName.Text = "Music Name";
			this.lblMusicName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel3.Controls.Add(this.lblListens, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.lblSinger, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.lblIconMusic, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.materialLabel1, 2, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(476, 29);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// lblListens
			// 
			this.lblListens.Depth = 0;
			this.lblListens.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblListens.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblListens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblListens.Location = new System.Drawing.Point(358, 0);
			this.lblListens.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblListens.Name = "lblListens";
			this.lblListens.Size = new System.Drawing.Size(115, 29);
			this.lblListens.TabIndex = 5;
			this.lblListens.Text = "Listen";
			this.lblListens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSinger
			// 
			this.lblSinger.Depth = 0;
			this.lblSinger.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSinger.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblSinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblSinger.Location = new System.Drawing.Point(40, 0);
			this.lblSinger.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblSinger.Name = "lblSinger";
			this.lblSinger.Size = new System.Drawing.Size(275, 29);
			this.lblSinger.TabIndex = 4;
			this.lblSinger.Text = "Singer";
			this.lblSinger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblIconMusic
			// 
			this.lblIconMusic.Depth = 0;
			this.lblIconMusic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblIconMusic.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblIconMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblIconMusic.Image = global::CustomControls.resrouce.voice_message_microphone_button;
			this.lblIconMusic.Location = new System.Drawing.Point(0, 0);
			this.lblIconMusic.Margin = new System.Windows.Forms.Padding(0);
			this.lblIconMusic.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblIconMusic.Name = "lblIconMusic";
			this.lblIconMusic.Size = new System.Drawing.Size(37, 29);
			this.lblIconMusic.TabIndex = 0;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Image = global::CustomControls.resrouce.headset_with_microphone;
			this.materialLabel1.Location = new System.Drawing.Point(318, 0);
			this.materialLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(37, 29);
			this.materialLabel1.TabIndex = 1;
			// 
			// CustomMusicItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "CustomMusicItem";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.Size = new System.Drawing.Size(476, 59);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
