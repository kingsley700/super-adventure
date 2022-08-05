using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using engine;

namespace Superadventure
{
    public partial class Form1 : Form
    {
        public Label lblHitPoints = new Label();
        public Label lblExperience = new Label();
        public Label lblLevel = new Label();
        public Label lblGold = new Label();

        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(lblExperience);
            this.Controls.Add(lblGold);
            this.Controls.Add(lblHitPoints);
            this.Controls.Add(lblLevel);

            lblExperience.Top = 0;
            lblGold.Top = 20;
            lblHitPoints.Top = 40;
            lblLevel.Top = 60;

            Player _player = new Player
            {
                CurrentHitPoints = 10,
                MaximumHitPoints = 10,
                Gold = 20,
                ExperiencePoints = 0,
                Level = 1
            };

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
    