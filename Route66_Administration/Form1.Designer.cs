
namespace Route66_Administration
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
            this.hentVinder = new System.Windows.Forms.Button();
            this.vinderTextbox = new System.Windows.Forms.TextBox();
            this.vinderlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hentVinder
            // 
            this.hentVinder.Location = new System.Drawing.Point(325, 159);
            this.hentVinder.Name = "hentVinder";
            this.hentVinder.Size = new System.Drawing.Size(75, 23);
            this.hentVinder.TabIndex = 3;
            this.hentVinder.Text = "Hent Vinder";
            this.hentVinder.UseVisualStyleBackColor = true;
            this.hentVinder.Click += new System.EventHandler(this.hentVinder_Click);
            // 
            // vinderTextbox
            // 
            this.vinderTextbox.Location = new System.Drawing.Point(325, 133);
            this.vinderTextbox.Name = "vinderTextbox";
            this.vinderTextbox.ReadOnly = true;
            this.vinderTextbox.Size = new System.Drawing.Size(100, 20);
            this.vinderTextbox.TabIndex = 4;
            // 
            // vinderlabel
            // 
            this.vinderlabel.AutoSize = true;
            this.vinderlabel.Location = new System.Drawing.Point(276, 136);
            this.vinderlabel.Name = "vinderlabel";
            this.vinderlabel.Size = new System.Drawing.Size(43, 13);
            this.vinderlabel.TabIndex = 5;
            this.vinderlabel.Text = "Vinder: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vinderlabel);
            this.Controls.Add(this.vinderTextbox);
            this.Controls.Add(this.hentVinder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hentVinder;
        private System.Windows.Forms.TextBox vinderTextbox;
        private System.Windows.Forms.Label vinderlabel;
    }
}

