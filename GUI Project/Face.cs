using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net.Mail;

namespace GUI_Project
{
    public partial class Face : Form
    {
        Start originalform;
        private OpenFileDialog openFile;
        private string key;
        private System.Drawing.Printing.PrintDocument imgToPrint;

        public Face( Start startform )
        {
            InitializeComponent();
            originalform = startform;
            openFile = new OpenFileDialog();
            key = "Zunggu#ten10";
            imgToPrint = new System.Drawing.Printing.PrintDocument();
            DoubleBuffered = true;
        }

        private void Face_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = originalform.m_face[0];
            pictureBox2.Image = originalform.m_face[0];
            pictureBox3.Image = originalform.m_face[1];
            pictureBox4.Image = originalform.m_face[2];

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }

        //
        // Options Button Functionality
        //
        private void optionsButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(optionsButton, new Point(0, shareButton.Height));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creates image of what is in the tablelayoutpane2
            Bitmap bitmap = new Bitmap(tableLayoutPanel2.Width, tableLayoutPanel2.Height);
            tableLayoutPanel2.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            // opens save file dialog and saves image to location selected
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:/users/lr10/desktop/";
            saveFileDialog1.Filter = "PNG|*.png|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        //
        // Edit Button Functionality
        //
        private void editButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(editButton, new Point(0, shareButton.Height));
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tableLayoutPanel2.BackColor = colorDialog1.Color;
            }
        }

        private void stretchedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tableLayoutPanel2.BackgroundImage = Image.FromFile(openFile.FileName);
                tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void tiledImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control c = this.tableLayoutPanel1.GetControlFromPosition(0, 0);
            
            
           
            openFile.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
               tableLayoutPanel2.BackgroundImage = Image.FromFile(openFile.FileName);
               tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Tile;
            }
        }

        private void deleteBackgroundImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.BackgroundImage = null;
        }


        //
        // Share Button Functionality
        //
        private void shareButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(shareButton, new Point(0, shareButton.Height));
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextMessage tm = new TextMessage();
            tm.ShowDialog();
        }

        private void emailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string to = " ";

            EmailMessage email = new EmailMessage();
            email.ShowDialog();
            to = email.to;

            if(to == null)
            {
                return;
            }

            // creates image of what is in the tablelayoutpane2
            Bitmap bitmap = new Bitmap(tableLayoutPanel2.Width, tableLayoutPanel2.Height);
            
            // draw the TableLayoutPanel control to the temporary bitmap image
            tableLayoutPanel2.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            bitmap.Save("c:/users/lr10/desktop/image.png");

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("leander.rodriguez@gmail.com");
            //mail.To.Add("lr10@me.com");
            mail.To.Add(to);
            mail.Subject = "I made this for you!";
            mail.Body = "mail with attachment";

            Attachment attachment = new System.Net.Mail.Attachment("c:/users/lr10/desktop/image.png");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("leander.rodriguez", key);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("Your email has been sent!");
        }
        
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creates image of what is in the tablelayoutpane2
            Bitmap bitmap = new Bitmap(tableLayoutPanel2.Width, tableLayoutPanel2.Height);

            // draw the TableLayoutPanel control to the temporary bitmap image
            tableLayoutPanel2.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            imgToPrint.PrintPage += (s, g) => g.Graphics.DrawImage(bitmap, 100, 100);
            imgToPrint.Print();
        }
    }
}
