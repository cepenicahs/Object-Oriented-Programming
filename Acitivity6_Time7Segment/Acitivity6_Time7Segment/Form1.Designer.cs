
namespace Acitivity6_Time7Segment
{
    partial class frmTime
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHours = new System.Windows.Forms.Button();
            this.btnMins = new System.Windows.Forms.Button();
            this.btnSecs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Start);
            // 
            // btnHours
            // 
            this.btnHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHours.FlatAppearance.BorderSize = 0;
            this.btnHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHours.Font = new System.Drawing.Font("Dela Gothic One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHours.ForeColor = System.Drawing.Color.Red;
            this.btnHours.Location = new System.Drawing.Point(138, 139);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(126, 89);
            this.btnHours.TabIndex = 0;
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.TextChanged += new System.EventHandler(this.hrTextChanged);
            // 
            // btnMins
            // 
            this.btnMins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMins.FlatAppearance.BorderSize = 0;
            this.btnMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMins.Font = new System.Drawing.Font("Dela Gothic One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMins.ForeColor = System.Drawing.Color.Red;
            this.btnMins.Location = new System.Drawing.Point(314, 139);
            this.btnMins.Name = "btnMins";
            this.btnMins.Size = new System.Drawing.Size(126, 89);
            this.btnMins.TabIndex = 1;
            this.btnMins.UseVisualStyleBackColor = true;
            this.btnMins.TextChanged += new System.EventHandler(this.minTextChanged);
            // 
            // btnSecs
            // 
            this.btnSecs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecs.FlatAppearance.BorderSize = 0;
            this.btnSecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecs.Font = new System.Drawing.Font("Dela Gothic One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecs.ForeColor = System.Drawing.Color.Red;
            this.btnSecs.Location = new System.Drawing.Point(490, 138);
            this.btnSecs.Name = "btnSecs";
            this.btnSecs.Size = new System.Drawing.Size(126, 89);
            this.btnSecs.TabIndex = 2;
            this.btnSecs.UseVisualStyleBackColor = true;
            this.btnSecs.TextChanged += new System.EventHandler(this.textChanged);
            this.btnSecs.Click += new System.EventHandler(this.btnSecs_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dela Gothic One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(198, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 89);
            this.button1.TabIndex = 3;
            this.button1.Text = "TIME NOW";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Dela Gothic One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(270, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 86);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Dela Gothic One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(446, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 86);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(745, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSecs);
            this.Controls.Add(this.btnMins);
            this.Controls.Add(this.btnHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.Load += new System.EventHandler(this.frmTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHours;
        private System.Windows.Forms.Button btnMins;
        private System.Windows.Forms.Button btnSecs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

