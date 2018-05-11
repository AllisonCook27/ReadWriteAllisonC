namespace ReadWriteAllisonC
{
    partial class frmReadWrite
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
            this.btnFile = new System.Windows.Forms.Button();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblCompare = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(109, 82);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(77, 30);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Check";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(23, 159);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(276, 18);
            this.lblDone.TabIndex = 1;
            this.lblDone.Text = "Output has been printed on a text file.";
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompare.Location = new System.Drawing.Point(12, 27);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(297, 18);
            this.lblCompare.TabIndex = 2;
            this.lblCompare.Text = "Compare strings on each line of a text file";
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase.Location = new System.Drawing.Point(38, 45);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(148, 18);
            this.lblCase.TabIndex = 3;
            this.lblCase.Text = "Case doesn\'t matter";
            // 
            // frmReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(316, 261);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.btnFile);
            this.Name = "frmReadWrite";
            this.Text = "File read and write by Allison C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Label lblCase;
    }
}

