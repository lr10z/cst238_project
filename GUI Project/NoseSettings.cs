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
    public partial class NoseSettings : Form
    {
        private Start originalform;
        private OpenFileDialog openFile;
        private PictureBox[] pb;
        private int idx;

        public NoseSettings( Start startform )
        {
            InitializeComponent();

            originalform = startform;
            openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            pb = new PictureBox[6];

            for (int i = 0; i < pb.Length; ++i)
            {
                pb[i] = new PictureBox();
            }

            idx = 0;

            imagesFull();
        }
        private void NoseSettings_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < originalform.m_noses.Length; ++i)
            {
                pb[i].Image = originalform.m_noses[i];
                pb[i].Dock = DockStyle.Fill;
                pb[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pb[i].Click += new EventHandler(pic_Click);
                tableLayoutPanel2.Controls.Add(pb[i]);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            Control tbl = sender as Control;

            int tblCell = tbl.TabIndex;

            openFile.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                originalform.m_noses[tblCell] = Image.FromFile(openFile.FileName);
                pb[tblCell].Image = originalform.m_noses[tblCell];
            }

            imagesFull();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();

            for (int i = 0; i < originalform.m_noses.Length; ++i)
            {
                originalform.m_noses[i] = null;
            }

            chooseDoneButton.Text = "Choose 6 Nose Images";
            chooseDoneButton.BackColor = SystemColors.ScrollBar;
        }

        private void chooseDoneButton_Click(object sender, EventArgs e)
        {
            if (chooseDoneButton.Text == "Done")
            {
                this.Close();
                Application.OpenForms[1].Show();
            }
            else
            {
                openFile.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in openFile.FileNames)
                    {
                        originalform.m_noses[idx] = Image.FromFile(file);
                        pb[idx].Image = originalform.m_noses[idx];
                        tableLayoutPanel2.Controls.Add(pb[idx]);
                        idx++;
                    }
                }
            }

            imagesFull();
        }

        private void imagesFull()
        {
            bool imfull = true;

            foreach (Image i in originalform.m_noses)
            {
                if (i == null)
                {
                    imfull = false;
                    break;
                }
            }

            if (imfull == true)
            {
                idx = 0;
                chooseDoneButton.BackColor = Color.FromArgb(128, 255, 128);
                chooseDoneButton.Text = "Done";
            }
            else
            {
                chooseDoneButton.BackColor = SystemColors.ScrollBar;
            }
        }
    }
}
