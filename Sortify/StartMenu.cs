using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortify
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            TimerLoadForm.Start();
        }

        private void TimerLoadForm_Tick(object sender, EventArgs e)
        {
            Opacity += .01;
            if (Opacity == 1)
            {
                TimerLoadForm.Stop();
                TimerCloseForm.Start();
            }
        }

        private void TimerCloseForm_Tick(object sender, EventArgs e)
        {
            Opacity -= .05;
            if (Opacity == 0)
            {
               this.Close();
            }
        }
    }
}
