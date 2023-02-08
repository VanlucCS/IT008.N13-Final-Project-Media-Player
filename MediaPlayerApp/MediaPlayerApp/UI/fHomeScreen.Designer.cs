
namespace MediaPlayerApp.UI
{
    partial class fHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHomeScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.pnRecent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOption = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenFile = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Recent media";
            // 
            // pnRecent
            // 
            this.pnRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRecent.AutoSize = true;
            this.pnRecent.Location = new System.Drawing.Point(10, 95);
            this.pnRecent.Name = "pnRecent";
            this.pnRecent.Size = new System.Drawing.Size(770, 410);
            this.pnRecent.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 30);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Home";
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.BorderRadius = 5;
            this.btnOption.BorderThickness = 1;
            this.btnOption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOption.FillColor = System.Drawing.SystemColors.Control;
            this.btnOption.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.Color.Black;
            this.btnOption.Location = new System.Drawing.Point(713, 22);
            this.btnOption.Name = "btnOption";
            this.btnOption.PressedColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOption.Size = new System.Drawing.Size(43, 35);
            this.btnOption.TabIndex = 51;
            this.btnOption.Text = "▼";
            this.btnOption.Visible = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.BorderRadius = 5;
            this.btnOpenFile.BorderThickness = 1;
            this.btnOpenFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFile.FillColor = System.Drawing.SystemColors.Control;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(585, 22);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.PressedColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenFile.Size = new System.Drawing.Size(127, 35);
            this.btnOpenFile.TabIndex = 50;
            this.btnOpenFile.Text = "Open file(s)";
            this.btnOpenFile.Visible = false;
            // 
            // fHomeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnRecent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHomeScreen";
            this.Text = "fHomeScreen";
            this.Load += new System.EventHandler(this.fHomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnRecent;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnOption;
        private Guna.UI2.WinForms.Guna2Button btnOpenFile;
    }
}