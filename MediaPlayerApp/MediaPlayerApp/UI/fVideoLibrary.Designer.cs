namespace MediaPlayerApp.UI
{
    partial class fVideoLibrary
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MediaPlayerApp.Properties.Resources.add_folder1;
            this.pictureBox1.Location = new System.Drawing.Point(620, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.Location = new System.Drawing.Point(609, 15);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(130, 40);
            this.btnAddFolder.TabIndex = 4;
            this.btnAddFolder.Text = "Add folder";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.MouseEnter += new System.EventHandler(this.btnAddFolder_MouseEnter);
            this.btnAddFolder.MouseLeave += new System.EventHandler(this.btnAddFolder_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(58, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Video";
            // 
            // lblSort
            // 
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(520, 64);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(218, 34);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sort by: Date modified     ▼";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSort.Leave += new System.EventHandler(this.lblSort_Leave);
            this.lblSort.MouseEnter += new System.EventHandler(this.lblSort_MouseEnter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(59, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 394);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // fVideoLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fVideoLibrary";
            this.Text = "fVideoLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}