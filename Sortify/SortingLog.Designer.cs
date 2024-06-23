namespace Sortify
{
    partial class SortingLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingLog));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            TopPanelIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            TopPanelText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            TopPanelHideButton = new Guna.UI2.WinForms.Guna2CircleButton();
            TopPanelMaxSizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            TopPanelCloseButton = new Guna.UI2.WinForms.Guna2CircleButton();
            sortingLogTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            TimerLoadForm = new System.Windows.Forms.Timer(components);
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TopPanelIcon).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.Control;
            TopPanel.Controls.Add(TopPanelIcon);
            TopPanel.Controls.Add(TopPanelText);
            TopPanel.Controls.Add(TopPanelHideButton);
            TopPanel.Controls.Add(TopPanelMaxSizeButton);
            TopPanel.Controls.Add(TopPanelCloseButton);
            TopPanel.CustomizableEdges = customizableEdges10;
            TopPanel.Location = new Point(-1, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.ShadowDecoration.CustomizableEdges = customizableEdges11;
            TopPanel.Size = new Size(461, 45);
            TopPanel.TabIndex = 1;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // TopPanelIcon
            // 
            TopPanelIcon.CustomizableEdges = customizableEdges5;
            TopPanelIcon.Image = Properties.Resources.Icon_Cmd;
            TopPanelIcon.ImageRotate = 0F;
            TopPanelIcon.Location = new Point(10, 7);
            TopPanelIcon.Name = "TopPanelIcon";
            TopPanelIcon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TopPanelIcon.Size = new Size(29, 29);
            TopPanelIcon.SizeMode = PictureBoxSizeMode.Zoom;
            TopPanelIcon.TabIndex = 5;
            TopPanelIcon.TabStop = false;
            // 
            // TopPanelText
            // 
            TopPanelText.BackColor = Color.Transparent;
            TopPanelText.Font = new Font("Segoe UI", 9.75F);
            TopPanelText.ForeColor = Color.FromArgb(125, 137, 149);
            TopPanelText.Location = new Point(40, 12);
            TopPanelText.Name = "TopPanelText";
            TopPanelText.Size = new Size(68, 19);
            TopPanelText.TabIndex = 8;
            TopPanelText.Text = "Sorting log";
            // 
            // TopPanelHideButton
            // 
            TopPanelHideButton.Animated = true;
            TopPanelHideButton.Cursor = Cursors.Hand;
            TopPanelHideButton.DisabledState.BorderColor = Color.DarkGray;
            TopPanelHideButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TopPanelHideButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TopPanelHideButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TopPanelHideButton.FillColor = Color.FromArgb(60, 181, 63);
            TopPanelHideButton.Font = new Font("Segoe UI", 9F);
            TopPanelHideButton.ForeColor = Color.White;
            TopPanelHideButton.HoverState.FillColor = Color.FromArgb(40, 161, 53);
            TopPanelHideButton.Location = new Point(370, 9);
            TopPanelHideButton.Name = "TopPanelHideButton";
            TopPanelHideButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            TopPanelHideButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            TopPanelHideButton.Size = new Size(25, 25);
            TopPanelHideButton.TabIndex = 7;
            TopPanelHideButton.Click += TopPanelHideButton_Click;
            // 
            // TopPanelMaxSizeButton
            // 
            TopPanelMaxSizeButton.Animated = true;
            TopPanelMaxSizeButton.Cursor = Cursors.Hand;
            TopPanelMaxSizeButton.DisabledState.BorderColor = Color.DarkGray;
            TopPanelMaxSizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TopPanelMaxSizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TopPanelMaxSizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TopPanelMaxSizeButton.FillColor = Color.FromArgb(233, 162, 75);
            TopPanelMaxSizeButton.Font = new Font("Segoe UI", 9F);
            TopPanelMaxSizeButton.ForeColor = Color.White;
            TopPanelMaxSizeButton.Location = new Point(398, 9);
            TopPanelMaxSizeButton.Name = "TopPanelMaxSizeButton";
            TopPanelMaxSizeButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TopPanelMaxSizeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            TopPanelMaxSizeButton.Size = new Size(25, 25);
            TopPanelMaxSizeButton.TabIndex = 6;
            // 
            // TopPanelCloseButton
            // 
            TopPanelCloseButton.Animated = true;
            TopPanelCloseButton.Cursor = Cursors.Hand;
            TopPanelCloseButton.DisabledState.BorderColor = Color.DarkGray;
            TopPanelCloseButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TopPanelCloseButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TopPanelCloseButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TopPanelCloseButton.FillColor = Color.FromArgb(223, 62, 66);
            TopPanelCloseButton.Font = new Font("Segoe UI", 9F);
            TopPanelCloseButton.ForeColor = Color.White;
            TopPanelCloseButton.HoverState.FillColor = Color.FromArgb(203, 52, 66);
            TopPanelCloseButton.Location = new Point(426, 9);
            TopPanelCloseButton.Name = "TopPanelCloseButton";
            TopPanelCloseButton.ShadowDecoration.CustomizableEdges = customizableEdges9;
            TopPanelCloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            TopPanelCloseButton.Size = new Size(25, 25);
            TopPanelCloseButton.TabIndex = 5;
            TopPanelCloseButton.Click += TopPanelCloseButton_Click;
            // 
            // sortingLogTextBox
            // 
            sortingLogTextBox.BorderRadius = 15;
            sortingLogTextBox.BorderThickness = 0;
            customizableEdges3.BottomLeft = false;
            customizableEdges3.BottomRight = false;
            sortingLogTextBox.CustomizableEdges = customizableEdges3;
            sortingLogTextBox.DefaultText = "";
            sortingLogTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            sortingLogTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            sortingLogTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            sortingLogTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            sortingLogTextBox.FillColor = SystemColors.Control;
            sortingLogTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sortingLogTextBox.Font = new Font("Segoe UI", 9F);
            sortingLogTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            sortingLogTextBox.Location = new Point(20, 66);
            sortingLogTextBox.Multiline = true;
            sortingLogTextBox.Name = "sortingLogTextBox";
            sortingLogTextBox.PasswordChar = '\0';
            sortingLogTextBox.PlaceholderText = "";
            sortingLogTextBox.ReadOnly = true;
            sortingLogTextBox.ScrollBars = ScrollBars.Vertical;
            sortingLogTextBox.SelectedText = "";
            sortingLogTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            sortingLogTextBox.Size = new Size(420, 350);
            sortingLogTextBox.TabIndex = 2;
            // 
            // ProgressBar
            // 
            ProgressBar.BorderRadius = 15;
            customizableEdges1.TopLeft = false;
            customizableEdges1.TopRight = false;
            ProgressBar.CustomizableEdges = customizableEdges1;
            ProgressBar.Location = new Point(20, 415);
            ProgressBar.Maximum = 30;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ProgressColor = Color.FromArgb(87, 164, 255);
            ProgressBar.ProgressColor2 = Color.FromArgb(87, 164, 255);
            ProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ProgressBar.Size = new Size(420, 40);
            ProgressBar.TabIndex = 3;
            ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // TimerLoadForm
            // 
            TimerLoadForm.Enabled = true;
            TimerLoadForm.Interval = 1;
            TimerLoadForm.Tick += TimerLoadForm_Tick;
            // 
            // SortingLog
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(460, 475);
            Controls.Add(ProgressBar);
            Controls.Add(sortingLogTextBox);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SortingLog";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SortingLog";
            Load += SortingLog_Load;
            Shown += SortingLog_Shown;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TopPanelIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2PictureBox TopPanelIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel TopPanelText;
        private Guna.UI2.WinForms.Guna2CircleButton TopPanelHideButton;
        private Guna.UI2.WinForms.Guna2CircleButton TopPanelMaxSizeButton;
        private Guna.UI2.WinForms.Guna2CircleButton TopPanelCloseButton;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2TextBox sortingLogTextBox;
        private System.Windows.Forms.Timer TimerLoadForm;
    }
}