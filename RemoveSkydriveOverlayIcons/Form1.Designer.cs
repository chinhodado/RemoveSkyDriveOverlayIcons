namespace RemoveSkydriveOverlayIcons
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
            this.buttonCheckTick = new System.Windows.Forms.Button();
            this.buttonRestoreTick = new System.Windows.Forms.Button();
            this.buttonRemoveTick = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCheckTick
            // 
            this.buttonCheckTick.Location = new System.Drawing.Point(12, 13);
            this.buttonCheckTick.Name = "buttonCheckTick";
            this.buttonCheckTick.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckTick.TabIndex = 0;
            this.buttonCheckTick.Text = "Check tick";
            this.buttonCheckTick.UseVisualStyleBackColor = true;
            this.buttonCheckTick.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRestoreTick
            // 
            this.buttonRestoreTick.Location = new System.Drawing.Point(93, 13);
            this.buttonRestoreTick.Name = "buttonRestoreTick";
            this.buttonRestoreTick.Size = new System.Drawing.Size(75, 23);
            this.buttonRestoreTick.TabIndex = 2;
            this.buttonRestoreTick.Text = "Restore tick";
            this.buttonRestoreTick.UseVisualStyleBackColor = true;
            this.buttonRestoreTick.Click += new System.EventHandler(this.buttonRestoreTick_Click);
            // 
            // buttonRemoveTick
            // 
            this.buttonRemoveTick.Location = new System.Drawing.Point(175, 12);
            this.buttonRemoveTick.Name = "buttonRemoveTick";
            this.buttonRemoveTick.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveTick.TabIndex = 3;
            this.buttonRemoveTick.Text = "Remove tick";
            this.buttonRemoveTick.UseVisualStyleBackColor = true;
            this.buttonRemoveTick.Click += new System.EventHandler(this.buttonRemoveTick_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(256, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 238);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonRemoveTick);
            this.Controls.Add(this.buttonRestoreTick);
            this.Controls.Add(this.buttonCheckTick);
            this.Name = "Form1";
            this.Text = "RSO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckTick;
        private System.Windows.Forms.Button buttonRestoreTick;
        private System.Windows.Forms.Button buttonRemoveTick;
        private System.Windows.Forms.ListBox listBox1;
    }
}

