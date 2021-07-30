namespace Alex_Casper_CPT_185_Final
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCelebrate = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(699, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnCelebrate
            // 
            this.btnCelebrate.Location = new System.Drawing.Point(12, 246);
            this.btnCelebrate.Name = "btnCelebrate";
            this.btnCelebrate.Size = new System.Drawing.Size(120, 42);
            this.btnCelebrate.TabIndex = 2;
            this.btnCelebrate.Text = "\"Ta-Da\"";
            this.btnCelebrate.UseVisualStyleBackColor = true;
            this.btnCelebrate.Click += new System.EventHandler(this.BtnCelebrate_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblAbout.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAbout.Location = new System.Drawing.Point(174, 123);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(481, 207);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "label1";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnCelebrate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(840, 339);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnCelebrate);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator made by: Alex Casper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCelebrate;
        private System.Windows.Forms.Label lblAbout;
    }
}