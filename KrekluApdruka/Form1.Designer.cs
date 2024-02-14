namespace KrekluApdruka
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
            this.piegade = new System.Windows.Forms.CheckBox();
            this.skaits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Teksts = new System.Windows.Forms.RadioButton();
            this.Zime = new System.Windows.Forms.RadioButton();
            this.Bilde = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.summa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skaits)).BeginInit();
            this.SuspendLayout();
            // 
            // piegade
            // 
            this.piegade.AutoSize = true;
            this.piegade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.piegade.Location = new System.Drawing.Point(53, 335);
            this.piegade.Name = "piegade";
            this.piegade.Size = new System.Drawing.Size(201, 21);
            this.piegade.TabIndex = 2;
            this.piegade.Text = "Vai nepieciešama piegāde?";
            this.piegade.UseVisualStyleBackColor = true;
            this.piegade.CheckedChanged += new System.EventHandler(this.piegade_CheckedChanged);
            // 
            // skaits
            // 
            this.skaits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.skaits.Location = new System.Drawing.Point(53, 291);
            this.skaits.Name = "skaits";
            this.skaits.Size = new System.Drawing.Size(144, 23);
            this.skaits.TabIndex = 3;
            this.skaits.ValueChanged += new System.EventHandler(this.skaits_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(50, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nepieciešamo kreklu skaits:";
            // 
            // Teksts
            // 
            this.Teksts.AutoSize = true;
            this.Teksts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Teksts.Location = new System.Drawing.Point(53, 173);
            this.Teksts.Name = "Teksts";
            this.Teksts.Size = new System.Drawing.Size(68, 21);
            this.Teksts.TabIndex = 5;
            this.Teksts.TabStop = true;
            this.Teksts.Text = "Teksts";
            this.Teksts.UseVisualStyleBackColor = true;
            this.Teksts.CheckedChanged += new System.EventHandler(this.Teksts_CheckedChanged);
            // 
            // Zime
            // 
            this.Zime.AutoSize = true;
            this.Zime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Zime.Location = new System.Drawing.Point(53, 200);
            this.Zime.Name = "Zime";
            this.Zime.Size = new System.Drawing.Size(57, 21);
            this.Zime.TabIndex = 6;
            this.Zime.TabStop = true;
            this.Zime.Text = "Zīme";
            this.Zime.UseVisualStyleBackColor = true;
            this.Zime.CheckedChanged += new System.EventHandler(this.Zime_CheckedChanged);
            // 
            // Bilde
            // 
            this.Bilde.AutoSize = true;
            this.Bilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bilde.Location = new System.Drawing.Point(53, 227);
            this.Bilde.Name = "Bilde";
            this.Bilde.Size = new System.Drawing.Size(57, 21);
            this.Bilde.TabIndex = 7;
            this.Bilde.TabStop = true;
            this.Bilde.Text = "Bilde";
            this.Bilde.UseVisualStyleBackColor = true;
            this.Bilde.CheckedChanged += new System.EventHandler(this.Bilde_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(49, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kāda veida apdruka nepieciešama?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(53, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aprēķināt summu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // summa
            // 
            this.summa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.summa.Location = new System.Drawing.Point(191, 386);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(100, 23);
            this.summa.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(53, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kreklu pasūtīšana.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bilde);
            this.Controls.Add(this.Zime);
            this.Controls.Add(this.Teksts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skaits);
            this.Controls.Add(this.piegade);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skaits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox piegade;
        private System.Windows.Forms.NumericUpDown skaits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Teksts;
        private System.Windows.Forms.RadioButton Zime;
        private System.Windows.Forms.RadioButton Bilde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox summa;
        private System.Windows.Forms.Label label3;
    }
}

