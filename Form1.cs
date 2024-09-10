using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEROGAMEPLEASE
{
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left,
        None
    }

    public partial class frmMain : Form
    {
        private GameEngine engine;
        public frmMain()
        {
            InitializeComponent();
            engine = new GameEngine(10);
            UpdateDisplay(engine);
        }

        private string UpdateDisplay(GameEngine engine)
        {
            lblDisplay.Text = engine.ToString();
            return engine.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //TriggerMovement();
            UpdateDisplay(engine);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //TriggerMovement();
            UpdateDisplay(engine);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //TriggerMovement();
            UpdateDisplay(engine);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //TriggerMovement();
            UpdateDisplay(engine);
        }
    }
}
