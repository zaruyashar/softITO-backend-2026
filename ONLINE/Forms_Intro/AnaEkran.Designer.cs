namespace Forms_Intro
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mutfakGereçleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elektronikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonMalzemeleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mutfakGereçleriToolStripMenuItem,
            this.salonMalzemeleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1671, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mutfakGereçleriToolStripMenuItem
            // 
            this.mutfakGereçleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kToolStripMenuItem,
            this.elektronikToolStripMenuItem});
            this.mutfakGereçleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutfakGereçleriToolStripMenuItem.Name = "mutfakGereçleriToolStripMenuItem";
            this.mutfakGereçleriToolStripMenuItem.Size = new System.Drawing.Size(400, 73);
            this.mutfakGereçleriToolStripMenuItem.Text = "Mutfak Gereçleri";
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.Size = new System.Drawing.Size(474, 74);
            this.kToolStripMenuItem.Text = "Küçük Eşyalar";
            this.kToolStripMenuItem.Click += new System.EventHandler(this.kToolStripMenuItem_Click);
            // 
            // elektronikToolStripMenuItem
            // 
            this.elektronikToolStripMenuItem.Name = "elektronikToolStripMenuItem";
            this.elektronikToolStripMenuItem.Size = new System.Drawing.Size(474, 74);
            this.elektronikToolStripMenuItem.Text = "Elektronik";
            // 
            // salonMalzemeleriToolStripMenuItem
            // 
            this.salonMalzemeleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonMalzemeleriToolStripMenuItem.Name = "salonMalzemeleriToolStripMenuItem";
            this.salonMalzemeleriToolStripMenuItem.Size = new System.Drawing.Size(438, 73);
            this.salonMalzemeleriToolStripMenuItem.Text = "Salon Malzemeleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(639, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Züccaciye";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1671, 1094);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mutfakGereçleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elektronikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonMalzemeleriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}