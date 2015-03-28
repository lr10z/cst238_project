namespace GUI_Project
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eyesMenuButton = new System.Windows.Forms.Button();
            this.noseMenuButton = new System.Windows.Forms.Button();
            this.mouthMenuButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.eyesMenuButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.noseMenuButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mouthMenuButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // eyesMenuButton
            // 
            this.eyesMenuButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eyesMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eyesMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eyesMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyesMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyesMenuButton.Location = new System.Drawing.Point(1, 1);
            this.eyesMenuButton.Margin = new System.Windows.Forms.Padding(1);
            this.eyesMenuButton.Name = "eyesMenuButton";
            this.eyesMenuButton.Size = new System.Drawing.Size(325, 132);
            this.eyesMenuButton.TabIndex = 0;
            this.eyesMenuButton.Text = "Choose Eye Images";
            this.eyesMenuButton.UseVisualStyleBackColor = false;
            this.eyesMenuButton.Click += new System.EventHandler(this.eyesMenuButton_Click);
            // 
            // noseMenuButton
            // 
            this.noseMenuButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.noseMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noseMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.noseMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noseMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noseMenuButton.Location = new System.Drawing.Point(1, 135);
            this.noseMenuButton.Margin = new System.Windows.Forms.Padding(1);
            this.noseMenuButton.Name = "noseMenuButton";
            this.noseMenuButton.Size = new System.Drawing.Size(325, 132);
            this.noseMenuButton.TabIndex = 1;
            this.noseMenuButton.Text = "Choose Nose Images";
            this.noseMenuButton.UseVisualStyleBackColor = false;
            this.noseMenuButton.Click += new System.EventHandler(this.noseMenuButton_Click);
            // 
            // mouthMenuButton
            // 
            this.mouthMenuButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mouthMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mouthMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mouthMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouthMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouthMenuButton.Location = new System.Drawing.Point(1, 269);
            this.mouthMenuButton.Margin = new System.Windows.Forms.Padding(1);
            this.mouthMenuButton.Name = "mouthMenuButton";
            this.mouthMenuButton.Size = new System.Drawing.Size(325, 132);
            this.mouthMenuButton.TabIndex = 2;
            this.mouthMenuButton.Text = "Choose Mouth Images";
            this.mouthMenuButton.UseVisualStyleBackColor = false;
            this.mouthMenuButton.Click += new System.EventHandler(this.mouthMenuButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Menu;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1, 403);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(325, 134);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "back to Start";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button eyesMenuButton;
        private System.Windows.Forms.Button noseMenuButton;
        private System.Windows.Forms.Button mouthMenuButton;
        private System.Windows.Forms.Button backButton;
    }
}