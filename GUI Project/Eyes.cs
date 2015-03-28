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
    public partial class Eyes : Form
    {
        Start originalform;
        private Button[] btn;

        public Eyes( Start startform )
        {
            InitializeComponent();
            originalform = startform;
            btn = new Button[6];

            for (int i = 0; i < btn.Length; ++i)
            {
                btn[i] = new Button();
            }
        }

        private void Eyes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < originalform.m_eyes.Length; ++i)
            {
                btn[i].Image = originalform.m_eyes[i];
                btn[i].Dock = DockStyle.Fill;
                btn[i].Margin = new Padding(1);
                btn[i].Click += new EventHandler(button_Click);
                btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                tableLayoutPanel2.Controls.Add(btn[i]);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            // identify which button was clicked and perform necessary actions
            Button button = sender as Button;

            originalform.m_face[0] = button.Image;
            this.Hide();

            Noses noses = new Noses(originalform);
            noses.ShowDialog();
        }
    }
}
