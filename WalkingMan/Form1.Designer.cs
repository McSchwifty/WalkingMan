namespace WalkingMan
{
    partial class frmWalkingMan
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
            this.btnMakeHimWalk = new System.Windows.Forms.Button();
            this.picMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeHimWalk
            // 
            this.btnMakeHimWalk.Location = new System.Drawing.Point(12, 12);
            this.btnMakeHimWalk.Name = "btnMakeHimWalk";
            this.btnMakeHimWalk.Size = new System.Drawing.Size(75, 170);
            this.btnMakeHimWalk.TabIndex = 0;
            this.btnMakeHimWalk.Text = "Make Him Walk";
            this.btnMakeHimWalk.UseVisualStyleBackColor = true;
            this.btnMakeHimWalk.Click += new System.EventHandler(this.btnMakeHimWalk_Click);
            // 
            // picMan
            // 
            this.picMan.Location = new System.Drawing.Point(556, 12);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(170, 170);
            this.picMan.TabIndex = 1;
            this.picMan.TabStop = false;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 194);
            this.Controls.Add(this.picMan);
            this.Controls.Add(this.btnMakeHimWalk);
            this.Name = "frmWalkingMan";
            this.Text = "Walking run";
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeHimWalk;
        private System.Windows.Forms.PictureBox picMan;
    }
}

