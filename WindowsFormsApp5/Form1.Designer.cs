namespace WindowsFormsApp5
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
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(295, 62);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 22);
            this.tbCod.TabIndex = 0;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(295, 118);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 1;
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(295, 176);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 22);
            this.tbNota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbCod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

