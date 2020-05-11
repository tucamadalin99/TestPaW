namespace WindowsFormsApp8
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
            this.components = new System.ComponentModel.Container();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.tbPreturi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(285, 51);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(181, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(285, 130);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(181, 22);
            this.tbNr.TabIndex = 1;
            this.tbNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNr_KeyPress);
            // 
            // tbPreturi
            // 
            this.tbPreturi.Location = new System.Drawing.Point(285, 220);
            this.tbPreturi.Name = "tbPreturi";
            this.tbPreturi.Size = new System.Drawing.Size(181, 22);
            this.tbPreturi.TabIndex = 2;
            this.tbPreturi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPreturi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume Hotel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numar camere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pret Camere:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "Deschide form2";
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
            this.Controls.Add(this.tbPreturi);
            this.Controls.Add(this.tbNr);
            this.Controls.Add(this.tbNume);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbNr;
        private System.Windows.Forms.TextBox tbPreturi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
    }
}

