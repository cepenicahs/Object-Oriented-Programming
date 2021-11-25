
namespace Activity3_TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 501);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn11.ForeColor = System.Drawing.Color.Black;
            this.btn11.Location = new System.Drawing.Point(44, 111);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(110, 95);
            this.btn11.TabIndex = 2;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.button_click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn12.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn12.ForeColor = System.Drawing.Color.Black;
            this.btn12.Location = new System.Drawing.Point(171, 111);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(110, 95);
            this.btn12.TabIndex = 3;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.button_click);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn21.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn21.ForeColor = System.Drawing.Color.Black;
            this.btn21.Location = new System.Drawing.Point(44, 221);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(110, 95);
            this.btn21.TabIndex = 4;
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.button_click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn22.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn22.ForeColor = System.Drawing.Color.Black;
            this.btn22.Location = new System.Drawing.Point(171, 221);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(110, 95);
            this.btn22.TabIndex = 6;
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.button_click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn13.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn13.ForeColor = System.Drawing.Color.Black;
            this.btn13.Location = new System.Drawing.Point(298, 111);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(110, 95);
            this.btn13.TabIndex = 5;
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.button_click);
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn23.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn23.ForeColor = System.Drawing.Color.Black;
            this.btn23.Location = new System.Drawing.Point(298, 221);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(110, 95);
            this.btn23.TabIndex = 7;
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.button_click);
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn31.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn31.ForeColor = System.Drawing.Color.Black;
            this.btn31.Location = new System.Drawing.Point(44, 335);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(110, 95);
            this.btn31.TabIndex = 8;
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.button_click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn32.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn32.ForeColor = System.Drawing.Color.Black;
            this.btn32.Location = new System.Drawing.Point(171, 335);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(110, 95);
            this.btn32.TabIndex = 9;
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.button_click);
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn33.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn33.ForeColor = System.Drawing.Color.Black;
            this.btn33.Location = new System.Drawing.Point(298, 335);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(110, 95);
            this.btn33.TabIndex = 10;
            this.btn33.UseVisualStyleBackColor = false;
            this.btn33.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Activity3_TicTacToe.Properties.Resources.d9afb2f0c922f34cb6ae8ad219f53ca3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 392);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Activity3_TicTacToe.Properties.Resources.text;
            this.pictureBox2.Location = new System.Drawing.Point(44, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 73);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(452, 524);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC TAC TOE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

