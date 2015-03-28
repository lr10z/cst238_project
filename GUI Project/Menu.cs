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
    public partial class Menu : Form
    {
        Start originalform;

        public Menu(Start startform)
        {
            InitializeComponent();

            originalform = startform;
            
            imagesFull();
        }

        private void eyesMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            EyeSettings eu = new EyeSettings(originalform);
            eu.ShowDialog();

            imagesFull();
        }
        
        private void noseMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            NoseSettings ns = new NoseSettings(originalform);
            ns.ShowDialog();

            imagesFull();
        }

        private void mouthMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MouthSettings ms = new MouthSettings(originalform);
            ms.ShowDialog();

            imagesFull();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void imagesFull()
        {
            bool imfull = true;

            foreach( Image i in originalform.m_eyes)
            {
                if( i == null)
                {
                    imfull = false;
                    break;
                }
            }
            
            foreach (Image i in originalform.m_noses)
            {
                if (i == null)
                {
                    imfull = false;
                    break;
                }
            }
            
            foreach (Image i in originalform.m_mouths)
            {
                if (i == null)
                {
                    imfull = false;
                    break;
                }
            }
            
            if(imfull == true)
            {
                backButton.BackColor = Color.FromArgb(128, 255, 128);
                backButton.FlatAppearance.BorderColor = Color.ForestGreen;
                backButton.Enabled = true;
                originalform.m_start = true;
            }
            else
            {
                backButton.BackColor = SystemColors.Menu;
                backButton.Enabled = false;
            }
        }
    }
}
