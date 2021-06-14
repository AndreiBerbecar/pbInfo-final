
namespace _3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblEnunt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Info;
            this.txt1.Location = new System.Drawing.Point(232, 278);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(132, 22);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Info;
            this.txt2.Location = new System.Drawing.Point(663, 279);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 22);
            this.txt2.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Bisque;
            this.btn1.Location = new System.Drawing.Point(467, 278);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 28);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Calculeaza";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEnunt
            // 
            this.lblEnunt.AutoSize = true;
            this.lblEnunt.BackColor = System.Drawing.Color.Transparent;
            this.lblEnunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunt.Location = new System.Drawing.Point(188, 220);
            this.lblEnunt.Name = "lblEnunt";
            this.lblEnunt.Size = new System.Drawing.Size(708, 32);
            this.lblEnunt.TabIndex = 3;
            this.lblEnunt.Text = "Se dă un număr. Să se afișeze rădăcina sa pătrată.";
            this.lblEnunt.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblEnunt);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblEnunt;
    }
}

