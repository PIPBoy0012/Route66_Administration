
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hentVinder
            // 
            this.hentVinder.Location = new System.Drawing.Point(64, 55);
            this.hentVinder.Name = "hentVinder";
            this.hentVinder.Size = new System.Drawing.Size(75, 23);
            this.hentVinder.TabIndex = 3;
            this.hentVinder.Text = "Hent Vinder";
            this.hentVinder.UseVisualStyleBackColor = true;
            this.hentVinder.Click += new System.EventHandler(this.hentVinder_Click);
            // 
            // vinderTextbox
            // 
            this.vinderTextbox.Location = new System.Drawing.Point(64, 29);
            this.vinderTextbox.Name = "vinderTextbox";
            this.vinderTextbox.ReadOnly = true;
            this.vinderTextbox.Size = new System.Drawing.Size(280, 20);
            this.vinderTextbox.TabIndex = 4;
            // 
            // vinderlabel
            // 
            this.vinderlabel.AutoSize = true;
            this.vinderlabel.Location = new System.Drawing.Point(15, 32);
            this.vinderlabel.Name = "vinderlabel";
            this.vinderlabel.Size = new System.Drawing.Size(43, 13);
            this.vinderlabel.TabIndex = 5;
            this.vinderlabel.Text = "Vinder: ";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 302);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.vinderlabel);
            this.Controls.Add(this.vinderTextbox);
            this.Controls.Add(this.hentVinder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hentVinder;
        private System.Windows.Forms.TextBox vinderTextbox;
        private System.Windows.Forms.Label vinderlabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

