﻿/*
 * Created by SharpDevelop.
 * User: chi_b
 * Date: Apr 05.2018
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CustomControls
{
	partial class CustomInputDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
			this.lblInput = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tblLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// tblLayout
			// 
			this.tblLayout.ColumnCount = 2;
			this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tblLayout.Controls.Add(this.lblInput, 0, 0);
			this.tblLayout.Controls.Add(this.txtInput, 1, 0);
			this.tblLayout.Location = new System.Drawing.Point(12, 12);
			this.tblLayout.Name = "tblLayout";
			this.tblLayout.RowCount = 1;
			this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblLayout.Size = new System.Drawing.Size(222, 27);
			this.tblLayout.TabIndex = 0;
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblInput.Location = new System.Drawing.Point(3, 0);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(41, 27);
			this.lblInput.TabIndex = 1;
			this.lblInput.Text = "Name :";
			this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtInput
			// 
			this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInput.Location = new System.Drawing.Point(50, 3);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(169, 21);
			this.txtInput.TabIndex = 0;
			this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
			// 
			// btnOk
			// 
			this.btnOk.AutoSize = true;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Enabled = false;
			this.btnOk.Location = new System.Drawing.Point(127, 48);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(41, 26);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(174, 48);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(57, 26);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// CustomInputDialog
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(243, 85);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.tblLayout);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CustomInputDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = " Input Dialog";
			this.tblLayout.ResumeLayout(false);
			this.tblLayout.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
  
		private System.Windows.Forms.TableLayoutPanel tblLayout;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}
