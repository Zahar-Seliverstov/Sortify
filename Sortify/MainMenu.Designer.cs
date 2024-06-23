namespace Sortify
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            TopPanelIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            TopPanelText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            TopPanelHideButton = new Guna.UI2.WinForms.Guna2CircleButton();
            TopPanelMaxSizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            TopPanelCloseButton = new Guna.UI2.WinForms.Guna2CircleButton();
            selectFolderButton = new Guna.UI2.WinForms.Guna2Button();
            mainMenuBackGround = new Guna.UI2.WinForms.Guna2PictureBox();
            timerLoadForm = new System.Windows.Forms.Timer(components);
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TopPanelIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainMenuBackGround).BeginInit();
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
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.ShadowDecoration.CustomizableEdges = customizableEdges11;
            TopPanel.Size = new Size(317, 45);
            TopPanel.TabIndex = 0;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // TopPanelIcon
            // 
            TopPanelIcon.CustomizableEdges = customizableEdges5;
            TopPanelIcon.Image = Properties.Resources.Logo;
            TopPanelIcon.ImageRotate = 0F;
            TopPanelIcon.Location = new Point(13, 9);
            TopPanelIcon.Name = "TopPanelIcon";
            TopPanelIcon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TopPanelIcon.Size = new Size(23, 23);
            TopPanelIcon.SizeMode = PictureBoxSizeMode.Zoom;
            TopPanelIcon.TabIndex = 5;
            TopPanelIcon.TabStop = false;
            // 
            // TopPanelText
            // 
            TopPanelText.BackColor = Color.Transparent;
            TopPanelText.Font = new Font("Segoe UI", 9.75F);
            TopPanelText.ForeColor = Color.FromArgb(125, 137, 149);
            TopPanelText.Location = new Point(42, 12);
            TopPanelText.Name = "TopPanelText";
            TopPanelText.Size = new Size(40, 19);
            TopPanelText.TabIndex = 8;
            TopPanelText.Text = "Sortify";
            // 
            // TopPanelHideButton
            // 
            TopPanelHideButton.Animated = true;
            TopPanelHideButton.BorderColor = Color.FromArgb(60, 181, 63);
            TopPanelHideButton.Cursor = Cursors.Hand;
            TopPanelHideButton.DisabledState.BorderColor = Color.DarkGray;
            TopPanelHideButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TopPanelHideButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TopPanelHideButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TopPanelHideButton.FillColor = Color.FromArgb(60, 181, 63);
            TopPanelHideButton.Font = new Font("Segoe UI", 9F);
            TopPanelHideButton.ForeColor = Color.White;
            TopPanelHideButton.HoverState.BorderColor = Color.FromArgb(60, 181, 63);
            TopPanelHideButton.HoverState.FillColor = Color.FromArgb(40, 161, 53);
            TopPanelHideButton.Location = new Point(225, 9);
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
            TopPanelMaxSizeButton.Location = new Point(253, 9);
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
            TopPanelCloseButton.Location = new Point(281, 9);
            TopPanelCloseButton.Name = "TopPanelCloseButton";
            TopPanelCloseButton.ShadowDecoration.CustomizableEdges = customizableEdges9;
            TopPanelCloseButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            TopPanelCloseButton.Size = new Size(25, 25);
            TopPanelCloseButton.TabIndex = 5;
            TopPanelCloseButton.Click += TopPanelCloseButton_Click;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Animated = true;
            selectFolderButton.BorderColor = Color.FromArgb(79, 160, 255);
            selectFolderButton.BorderRadius = 18;
            selectFolderButton.BorderThickness = 5;
            selectFolderButton.Cursor = Cursors.Hand;
            selectFolderButton.CustomizableEdges = customizableEdges3;
            selectFolderButton.DisabledState.BorderColor = Color.DarkGray;
            selectFolderButton.DisabledState.CustomBorderColor = Color.DarkGray;
            selectFolderButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            selectFolderButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            selectFolderButton.FillColor = Color.FromArgb(87, 164, 255);
            selectFolderButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            selectFolderButton.ForeColor = SystemColors.ButtonFace;
            selectFolderButton.ImeMode = ImeMode.HangulFull;
            selectFolderButton.Location = new Point(29, 284);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Padding = new Padding(0, 0, 0, 2);
            selectFolderButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            selectFolderButton.Size = new Size(258, 67);
            selectFolderButton.TabIndex = 2;
            selectFolderButton.Text = "Select Folder";
            selectFolderButton.Click += SelectFolderButton_Click;
            // 
            // mainMenuBackGround
            // 
            mainMenuBackGround.CustomizableEdges = customizableEdges1;
            mainMenuBackGround.FillColor = Color.Transparent;
            mainMenuBackGround.Image = Properties.Resources.Back_ground;
            mainMenuBackGround.ImageRotate = 0F;
            mainMenuBackGround.Location = new Point(67, 76);
            mainMenuBackGround.Name = "mainMenuBackGround";
            mainMenuBackGround.ShadowDecoration.CustomizableEdges = customizableEdges2;
            mainMenuBackGround.Size = new Size(180, 180);
            mainMenuBackGround.SizeMode = PictureBoxSizeMode.Zoom;
            mainMenuBackGround.TabIndex = 4;
            mainMenuBackGround.TabStop = false;
            // 
            // timerLoadForm
            // 
            timerLoadForm.Enabled = true;
            timerLoadForm.Interval = 10;
            timerLoadForm.Tick += TimerLoadForm_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(316, 380);
            Controls.Add(mainMenuBackGround);
            Controls.Add(selectFolderButton);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sortify";
            Load += MainMenu_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TopPanelIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainMenuBackGround).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Button selectFolderButton;
        private Guna.UI2.WinForms.Guna2PictureBox mainMenuBackGround;
        private Guna.UI2.WinForms.Guna2CircleButton TopPanelCloseButton;
        private Guna.UI2.WinForms.Guna2CircleButton TopPanelHideButton;
        private Guna.UI2.WinForms.Guna2CircleButton TopPanelMaxSizeButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel TopPanelText;
        private Guna.UI2.WinForms.Guna2PictureBox TopPanelIcon;
        private System.Windows.Forms.Timer timerLoadForm;
    }
}
