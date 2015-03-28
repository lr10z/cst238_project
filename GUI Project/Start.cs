using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class Start : Form
    {
        public Boolean m_start;
        public Image[] m_eyes;
        public Image[] m_noses;
        public Image[] m_mouths;
        public Image[] m_face;

        public Start()
        {
            InitializeComponent();

            m_start = false;
            m_eyes = new Image[6];
            m_noses = new Image[6];
            m_mouths = new Image[6];
            m_face = new Image[3];

            
            if( m_start == false )
            {
               // start button is disabled;
               startButton.BackColor = SystemColors.Menu;
               startButton.FlatAppearance.BorderColor = Color.Black;
               startButton.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Opens and goes to eyes images
            this.Hide();

            Eyes eyes = new Eyes(this);
            eyes.ShowDialog();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            // Opens and goes to main menu
            this.Hide();

            Menu menu = new Menu(this);
            menu.ShowDialog();

            if (m_start == true)
            {
                // start button is enabled
                startButton.BackColor = Color.FromArgb(128, 255, 128);
                startButton.FlatAppearance.BorderColor = Color.ForestGreen;
                startButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    
}
