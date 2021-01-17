
namespace Paint
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.white = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.grpActivateColor = new System.Windows.Forms.GroupBox();
            this.btnActivateColor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grpColor.SuspendLayout();
            this.grpActivateColor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(-1, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(949, 421);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // grpColor
            // 
            this.grpColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpColor.Controls.Add(this.white);
            this.grpColor.Controls.Add(this.black);
            this.grpColor.Controls.Add(this.green);
            this.grpColor.Controls.Add(this.blue);
            this.grpColor.Controls.Add(this.red);
            this.grpColor.Controls.Add(this.grpActivateColor);
            this.grpColor.Location = new System.Drawing.Point(0, 445);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(950, 52);
            this.grpColor.TabIndex = 1;
            this.grpColor.TabStop = false;
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(217, 19);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(29, 24);
            this.white.TabIndex = 3;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(182, 19);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(29, 24);
            this.black.TabIndex = 3;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.green.Location = new System.Drawing.Point(147, 19);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(29, 24);
            this.green.TabIndex = 3;
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(112, 19);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(29, 24);
            this.blue.TabIndex = 3;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(77, 19);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(29, 24);
            this.red.TabIndex = 3;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // grpActivateColor
            // 
            this.grpActivateColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActivateColor.Controls.Add(this.btnActivateColor);
            this.grpActivateColor.Location = new System.Drawing.Point(0, 9);
            this.grpActivateColor.Name = "grpActivateColor";
            this.grpActivateColor.Size = new System.Drawing.Size(59, 43);
            this.grpActivateColor.TabIndex = 2;
            this.grpActivateColor.TabStop = false;
            // 
            // btnActivateColor
            // 
            this.btnActivateColor.Location = new System.Drawing.Point(12, 10);
            this.btnActivateColor.Name = "btnActivateColor";
            this.btnActivateColor.Size = new System.Drawing.Size(29, 24);
            this.btnActivateColor.TabIndex = 3;
            this.btnActivateColor.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 500);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grpColor.ResumeLayout(false);
            this.grpActivateColor.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.GroupBox grpActivateColor;
        private System.Windows.Forms.Button btnActivateColor;
        private System.Windows.Forms.Button white;
    }
}

