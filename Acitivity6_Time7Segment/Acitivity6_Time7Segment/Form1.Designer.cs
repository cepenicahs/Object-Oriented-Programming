
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Start);
            // 
            // btnHours
            // 
            this.btnHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHours.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHours.ForeColor = System.Drawing.Color.Red;
            this.btnHours.Location = new System.Drawing.Point(151, 139);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(126, 89);
            this.btnHours.TabIndex = 0;
            this.btnHours.Text = "HH";
            this.btnHours.UseVisualStyleBackColor = true;
            // 
            // btnMins
            // 
            this.btnMins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMins.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMins.ForeColor = System.Drawing.Color.Red;
            this.btnMins.Location = new System.Drawing.Point(306, 139);
            this.btnMins.Name = "btnMins";
            this.btnMins.Size = new System.Drawing.Size(126, 89);
            this.btnMins.TabIndex = 1;
            this.btnMins.Text = "HH";
            this.btnMins.UseVisualStyleBackColor = true;
            // 
            // btnSecs
            // 
            this.btnSecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecs.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecs.ForeColor = System.Drawing.Color.Red;
            this.btnSecs.Location = new System.Drawing.Point(460, 139);
            this.btnSecs.Name = "btnSecs";
            this.btnSecs.Size = new System.Drawing.Size(126, 89);
            this.btnSecs.TabIndex = 2;
            this.btnSecs.Text = "HH";
            this.btnSecs.UseVisualStyleBackColor = true;
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

