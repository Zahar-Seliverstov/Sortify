namespace Sortify
{
    public partial class MainMenu : Form
    {
        private Point startPoint;
        private bool drag;

        public MainMenu()
        {
            InitializeComponent();
            startPoint = new Point(0, 0);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timerLoadForm.Start();
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            SortingLog form = new SortingLog();
            form.ShowDialog();
        }

        private void TimerLoadForm_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
        }
        //
        // Top panel
        //
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point position = PointToScreen(e.Location);
                this.Location = new Point(position.X - startPoint.X, position.Y - startPoint.Y);
            }
        }

        private void TopPanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanelHideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
