
namespace osu_ScorePost
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
            this.picTarget = new System.Windows.Forms.PictureBox();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // picTarget
            // 
            this.picTarget.Location = new System.Drawing.Point(68, 24);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(825, 529);
            this.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTarget.TabIndex = 0;
            this.picTarget.TabStop = false;
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(899, 24);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(348, 30);
            this.btnClickHere.TabIndex = 1;
            this.btnClickHere.Text = "Transcribe Text";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(68, 559);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(825, 86);
            this.txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 657);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.picTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

