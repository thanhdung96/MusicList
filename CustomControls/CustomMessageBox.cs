using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace CustomControls
{
	public partial class CustomMessageBox : Form
	{
		class AnimateMsgBox
		{
			public Size FormSize;
			public CustomMessageBox.AnimateStyle Style;
 
			public AnimateMsgBox(Size formSize, CustomMessageBox.AnimateStyle style)
			{
				this.FormSize = formSize;
				this.Style = style;
			}
		}
		
		public enum Buttons
		{
			AbortRetryIgnore = 1,
			OK = 2,
			OKCancel = 3,
			RetryCancel = 4,
			YesNo = 5,
			YesNoCancel = 6
		}
 
		// Các icon thể hiện nội dung của Msg
		public enum Icon
		{
			Application = 1,
			Exclamation = 2,
			Error = 3,
			Warning = 4,
			Info = 5,
			Question = 6,
			Shield = 7,
			Search = 8
		}
		// Hiệu ứng Show Msg
		public enum AnimateStyle
		{
			SlideDown = 1,
			FadeIn = 2,
			ZoomIn = 3
		}
		// Bóng đổ
		private const int CS_DROPSHADOW = 0x00020000;
 
		private static CustomMessageBox _msgBox;
 
		// Header, Footer và Icon
		private Panel _plHeader = new Panel();
		private Label _lblTitle;
		private Panel _plFooter = new Panel();
		private Panel _plIcon = new Panel();
		private PictureBox _picIcon = new PictureBox();
 
		// THông điệp
		private Label _lblMessage;
 
		// Panel
		private FlowLayoutPanel _flpButtons = new FlowLayoutPanel();
 
		// List các button
		private List<Button> _buttonCollection = new List<Button>();
 
		// Kết quả
		private static DialogResult _buttonResult = new DialogResult();
 
		// Timer hiệu ứng
		private static Timer _timer;
 
		// Phát tiếng Beep
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern bool MessageBeep(uint type);
		
		public CustomMessageBox()
		{
			InitializeComponent();
			
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.BackColor = Color.FromArgb(45, 45, 48);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Padding = new System.Windows.Forms.Padding(3);
			this.Width = 400;
 
			// Header
			_lblTitle = new Label();
			_lblTitle.ForeColor = Color.White;
			_lblTitle.Font = new System.Drawing.Font("Segoe UI", 18);
			_lblTitle.Dock = DockStyle.Top;
			_lblTitle.Height = 60;
 
			// Thông điệp
			_lblMessage = new Label();
			_lblMessage.ForeColor = Color.White;
			_lblMessage.Font = new System.Drawing.Font("Segoe UI", 10);
			_lblMessage.Dock = DockStyle.Fill;
 
			_flpButtons.FlowDirection = FlowDirection.RightToLeft;
			_flpButtons.Dock = DockStyle.Fill;
 
			_plHeader.Dock = DockStyle.Fill;
			_plHeader.Padding = new Padding(20);
			_plHeader.Controls.Add(_lblMessage);
			_plHeader.Controls.Add(_lblTitle);
 
			_plFooter.Dock = DockStyle.Bottom;
			_plFooter.Padding = new Padding(20);
			_plFooter.BackColor = Color.FromArgb(37, 37, 38);
			_plFooter.Height = 80;
			_plFooter.Controls.Add(_flpButtons);
 
			_picIcon.Width = 32;
			_picIcon.Height = 32;
			_picIcon.Location = new Point(30, 50);
 
			_plIcon.Dock = DockStyle.Left;
			_plIcon.Padding = new Padding(20);
			_plIcon.Width = 70;
			_plIcon.Controls.Add(_picIcon);
 
			// Add controls vào form
			this.Controls.Add(_plHeader);
			this.Controls.Add(_plIcon);
			this.Controls.Add(_plFooter);
		}
		private static void InitButtons(Buttons buttons)
		{
			switch (buttons) {
				case CustomMessageBox.Buttons.AbortRetryIgnore:
					_msgBox.InitAbortRetryIgnoreButtons();
					break;
 
				case CustomMessageBox.Buttons.OK:
					_msgBox.InitOKButton();
					break;
 
				case CustomMessageBox.Buttons.OKCancel:
					_msgBox.InitOKCancelButtons();
					break;
 
				case CustomMessageBox.Buttons.RetryCancel:
					_msgBox.InitRetryCancelButtons();
					break;
 
				case CustomMessageBox.Buttons.YesNo:
					_msgBox.InitYesNoButtons();
					break;
 
				case CustomMessageBox.Buttons.YesNoCancel:
					_msgBox.InitYesNoCancelButtons();
					break;
			}
 
			foreach (Button btn in _msgBox._buttonCollection) {
				btn.ForeColor = Color.FromArgb(170, 170, 170);
				btn.Font = new System.Drawing.Font("Segoe UI", 8);
				btn.Padding = new Padding(3);
				btn.FlatStyle = FlatStyle.Flat;
				btn.Height = 30;
				btn.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 98);
 
				_msgBox._flpButtons.Controls.Add(btn);
			}
		}
 
		private static void InitIcon(Icon icon)
		{
			switch (icon) {
				case CustomMessageBox.Icon.Application:
					_msgBox._picIcon.Image = SystemIcons.Application.ToBitmap();
					break;
 
				case CustomMessageBox.Icon.Exclamation:
					_msgBox._picIcon.Image = SystemIcons.Exclamation.ToBitmap();
					break;
 
				case CustomMessageBox.Icon.Error:
					_msgBox._picIcon.Image = SystemIcons.Error.ToBitmap();
					break;
 
				case CustomMessageBox.Icon.Info:
					_msgBox._picIcon.Image = SystemIcons.Information.ToBitmap();
					break;
 
				case CustomMessageBox.Icon.Question:
					_msgBox._picIcon.Image = SystemIcons.Question.ToBitmap();
					break;
 
				case CustomMessageBox.Icon.Shield:
					_msgBox._picIcon.Image = SystemIcons.Shield.ToBitmap();
					break;
 
				case CustomMessageBox.Icon.Warning:
					_msgBox._picIcon.Image = SystemIcons.Warning.ToBitmap();
					break;
			}
		}
 
		private void InitAbortRetryIgnoreButtons()
		{
			Button btnAbort = new Button();
			btnAbort.Text = "Abort";
			btnAbort.Click += ButtonClick;
 
			Button btnRetry = new Button();
			btnRetry.Text = "Retry";
			btnRetry.Click += ButtonClick;
 
			Button btnIgnore = new Button();
			btnIgnore.Text = "Ignore";
			btnIgnore.Click += ButtonClick;
 
			this._buttonCollection.Add(btnAbort);
			this._buttonCollection.Add(btnRetry);
			this._buttonCollection.Add(btnIgnore);
		}
 
		private void InitOKButton()
		{
			Button btnOK = new Button();
			btnOK.Text = "OK";
			btnOK.Click += ButtonClick;
 
			this._buttonCollection.Add(btnOK);
		}
 
		private void InitOKCancelButtons()
		{
			Button btnOK = new Button();
			btnOK.Text = "OK";
			btnOK.Click += ButtonClick;
 
			Button btnCancel = new Button();
			btnCancel.Text = "Cancel";
			btnCancel.Click += ButtonClick;
 
			this._buttonCollection.Add(btnOK);
			this._buttonCollection.Add(btnCancel);
		}
 
		private void InitRetryCancelButtons()
		{
			Button btnRetry = new Button();
			btnRetry.Text = "OK";
			btnRetry.Click += ButtonClick;
 
			Button btnCancel = new Button();
			btnCancel.Text = "Cancel";
			btnCancel.Click += ButtonClick;
 
			this._buttonCollection.Add(btnRetry);
			this._buttonCollection.Add(btnCancel);
		}
 
		private void InitYesNoButtons()
		{
			Button btnYes = new Button();
			btnYes.Text = "Yes";
			btnYes.Click += ButtonClick;
 
			Button btnNo = new Button();
			btnNo.Text = "No";
			btnNo.Click += ButtonClick;
 
			this._buttonCollection.Add(btnYes);
			this._buttonCollection.Add(btnNo);
		}
 
		private void InitYesNoCancelButtons()
		{
			Button btnYes = new Button();
			btnYes.Text = "Abort";
			btnYes.Click += ButtonClick;
 
			Button btnNo = new Button();
			btnNo.Text = "Retry";
			btnNo.Click += ButtonClick;
 
			Button btnCancel = new Button();
			btnCancel.Text = "Cancel";
			btnCancel.Click += ButtonClick;
 
			this._buttonCollection.Add(btnYes);
			this._buttonCollection.Add(btnNo);
			this._buttonCollection.Add(btnCancel);
		}
 
		private static void ButtonClick(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
 
			switch (btn.Text) {
				case "Abort":
					_buttonResult = DialogResult.Abort;
					break;
 
				case "Retry":
					_buttonResult = DialogResult.Retry;
					break;
 
				case "Ignore":
					_buttonResult = DialogResult.Ignore;
					break;
 
				case "OK":
					_buttonResult = DialogResult.OK;
					break;
 
				case "Cancel":
					_buttonResult = DialogResult.Cancel;
					break;
 
				case "Yes":
					_buttonResult = DialogResult.Yes;
					break;
 
				case "No":
					_buttonResult = DialogResult.No;
					break;
			}
 
			_msgBox.Dispose();
		}
 
		private static Size MessageSize(string message)
		{
			Graphics g = _msgBox.CreateGraphics();
			int width = 350;
			int height = 230;
 
			SizeF size = g.MeasureString(message, new System.Drawing.Font("Segoe UI", 10));
 
			if (message.Length < 150) {
				if ((int)size.Width > 350) {
					width = (int)size.Width;
				}
			} else {
				string[] groups = (from Match m in Regex.Matches(message, ".{1,180}")
				                               select m.Value).ToArray();
				int lines = groups.Length + 1;
				width = 700;
				height += (int)(size.Height + 10) * lines;
			}
			return new Size(width, height);
		}
		protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
 
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Pen pen = new Pen(Color.FromArgb(0, 151, 251));
 
            g.DrawRectangle(pen, rect);
        }
        static void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            AnimateMsgBox animate = (AnimateMsgBox)timer.Tag;
 
            switch(animate.Style){
                case CustomMessageBox.AnimateStyle.SlideDown:
                    if (_msgBox.Height < animate.FormSize.Height)
                    {
                        _msgBox.Height += 17;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;
 
                case CustomMessageBox.AnimateStyle.FadeIn:
                    if (_msgBox.Opacity < 1)
                    {
                        _msgBox.Opacity += 0.1;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;
 
                case CustomMessageBox.AnimateStyle.ZoomIn:
                    if (_msgBox.Width > animate.FormSize.Width )
                    {
                        _msgBox.Width -= 17;
                        _msgBox.Invalidate();
                    }
                    if (_msgBox.Height > animate.FormSize.Height)
                    {
                        _msgBox.Height -= 17;
                        _msgBox.Invalidate();
                    }
                    break;
            }
        }
        public static void Show(string message)
        {
            _msgBox = new CustomMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox.ShowDialog();
            MessageBeep(0);
        }
 
        public static void Show(string message, string title)
        {
            _msgBox = new CustomMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Size = CustomMessageBox.MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
        }
 
        public static DialogResult Show(string message, string title, Buttons buttons)
        {
            _msgBox = new CustomMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox._plIcon.Hide();
 
            CustomMessageBox.InitButtons(buttons);
 
            _msgBox.Size = CustomMessageBox.MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }
 
        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon)
        {
            _msgBox = new CustomMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
 
            CustomMessageBox.InitButtons(buttons);
            CustomMessageBox.InitIcon(icon);
 
            _msgBox.Size = CustomMessageBox.MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }
 
        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon, AnimateStyle style)
        {
            _msgBox = new CustomMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Height = 0;
 
            CustomMessageBox.InitButtons(buttons);
            CustomMessageBox.InitIcon(icon);
 
            _timer = new Timer();
            Size formSize = CustomMessageBox.MessageSize(message);
 
            switch (style)
            {
                case CustomMessageBox.AnimateStyle.SlideDown:
                    _msgBox.Size = new Size(formSize.Width, 0);
                    _timer.Interval = 1;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;
 
                case CustomMessageBox.AnimateStyle.FadeIn:
                    _msgBox.Size = formSize;
                    _msgBox.Opacity = 0;
                    _timer.Interval = 20;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;
 
                case CustomMessageBox.AnimateStyle.ZoomIn:
                    _msgBox.Size = new Size(formSize.Width + 100, formSize.Height + 100);
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    _timer.Interval = 1;
                    break;
            }
 
            _timer.Tick += timer_Tick;
            _timer.Start();
 
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }
	}
}
