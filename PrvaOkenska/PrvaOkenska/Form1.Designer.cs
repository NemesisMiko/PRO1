namespace PrvaOkenska
{
    partial class Kalkulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textprvo = new System.Windows.Forms.TextBox();
            this.textdrugo = new System.Windows.Forms.TextBox();
            this.textrez = new System.Windows.Forms.TextBox();
            this.btnRezultat = new System.Windows.Forms.Button();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.groupBoxop = new System.Windows.Forms.GroupBox();
            this.rbSestej = new System.Windows.Forms.RadioButton();
            this.rbOdstej = new System.Windows.Forms.RadioButton();
            this.rbMnozi = new System.Windows.Forms.RadioButton();
            this.rbDeli = new System.Windows.Forms.RadioButton();
            this.cbNeg = new System.Windows.Forms.CheckBox();
            this.groupBoxop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvo stevilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugo stevilo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(64, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezultat: ";
            // 
            // textprvo
            // 
            this.textprvo.Location = new System.Drawing.Point(228, 43);
            this.textprvo.Name = "textprvo";
            this.textprvo.Size = new System.Drawing.Size(100, 20);
            this.textprvo.TabIndex = 3;
            // 
            // textdrugo
            // 
            this.textdrugo.Location = new System.Drawing.Point(228, 111);
            this.textdrugo.Name = "textdrugo";
            this.textdrugo.Size = new System.Drawing.Size(100, 20);
            this.textdrugo.TabIndex = 4;
            // 
            // textrez
            // 
            this.textrez.Location = new System.Drawing.Point(228, 167);
            this.textrez.Name = "textrez";
            this.textrez.Size = new System.Drawing.Size(100, 20);
            this.textrez.TabIndex = 5;
            // 
            // btnRezultat
            // 
            this.btnRezultat.Location = new System.Drawing.Point(64, 233);
            this.btnRezultat.Name = "btnRezultat";
            this.btnRezultat.Size = new System.Drawing.Size(135, 70);
            this.btnRezultat.TabIndex = 6;
            this.btnRezultat.Text = "Rezultat";
            this.btnRezultat.UseVisualStyleBackColor = true;
            this.btnRezultat.Click += new System.EventHandler(this.btnRezultat_Click);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Location = new System.Drawing.Point(228, 233);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(129, 70);
            this.btnIzhod.TabIndex = 7;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // groupBoxop
            // 
            this.groupBoxop.Controls.Add(this.rbDeli);
            this.groupBoxop.Controls.Add(this.rbMnozi);
            this.groupBoxop.Controls.Add(this.rbOdstej);
            this.groupBoxop.Controls.Add(this.rbSestej);
            this.groupBoxop.Location = new System.Drawing.Point(428, 43);
            this.groupBoxop.Name = "groupBoxop";
            this.groupBoxop.Size = new System.Drawing.Size(113, 178);
            this.groupBoxop.TabIndex = 8;
            this.groupBoxop.TabStop = false;
            this.groupBoxop.Text = "Operacije";
            // 
            // rbSestej
            // 
            this.rbSestej.AutoSize = true;
            this.rbSestej.Location = new System.Drawing.Point(7, 34);
            this.rbSestej.Name = "rbSestej";
            this.rbSestej.Size = new System.Drawing.Size(78, 17);
            this.rbSestej.TabIndex = 0;
            this.rbSestej.TabStop = true;
            this.rbSestej.Text = "Sestevanje";
            this.rbSestej.UseVisualStyleBackColor = true;
            // 
            // rbOdstej
            // 
            this.rbOdstej.AutoSize = true;
            this.rbOdstej.Location = new System.Drawing.Point(7, 70);
            this.rbOdstej.Name = "rbOdstej";
            this.rbOdstej.Size = new System.Drawing.Size(79, 17);
            this.rbOdstej.TabIndex = 1;
            this.rbOdstej.TabStop = true;
            this.rbOdstej.Text = "Odstevanje";
            this.rbOdstej.UseVisualStyleBackColor = true;
            // 
            // rbMnozi
            // 
            this.rbMnozi.AutoSize = true;
            this.rbMnozi.Location = new System.Drawing.Point(7, 105);
            this.rbMnozi.Name = "rbMnozi";
            this.rbMnozi.Size = new System.Drawing.Size(71, 17);
            this.rbMnozi.TabIndex = 2;
            this.rbMnozi.TabStop = true;
            this.rbMnozi.Text = "Mnozenje";
            this.rbMnozi.UseVisualStyleBackColor = true;
            // 
            // rbDeli
            // 
            this.rbDeli.AutoSize = true;
            this.rbDeli.Location = new System.Drawing.Point(7, 143);
            this.rbDeli.Name = "rbDeli";
            this.rbDeli.Size = new System.Drawing.Size(63, 17);
            this.rbDeli.TabIndex = 3;
            this.rbDeli.TabStop = true;
            this.rbDeli.Text = "Deljenje";
            this.rbDeli.UseVisualStyleBackColor = true;
            // 
            // cbNeg
            // 
            this.cbNeg.AutoSize = true;
            this.cbNeg.Location = new System.Drawing.Point(428, 258);
            this.cbNeg.Name = "cbNeg";
            this.cbNeg.Size = new System.Drawing.Size(75, 17);
            this.cbNeg.TabIndex = 9;
            this.cbNeg.Text = "Negativno";
            this.cbNeg.UseVisualStyleBackColor = true;
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 375);
            this.Controls.Add(this.cbNeg);
            this.Controls.Add(this.groupBoxop);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.btnRezultat);
            this.Controls.Add(this.textrez);
            this.Controls.Add(this.textdrugo);
            this.Controls.Add(this.textprvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kalkulator";
            this.Text = "Enostaven kalkulator";
            this.groupBoxop.ResumeLayout(false);
            this.groupBoxop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textprvo;
        private System.Windows.Forms.TextBox textdrugo;
        private System.Windows.Forms.TextBox textrez;
        private System.Windows.Forms.Button btnRezultat;
        private System.Windows.Forms.Button btnIzhod;
        private System.Windows.Forms.GroupBox groupBoxop;
        private System.Windows.Forms.RadioButton rbDeli;
        private System.Windows.Forms.RadioButton rbMnozi;
        private System.Windows.Forms.RadioButton rbOdstej;
        private System.Windows.Forms.RadioButton rbSestej;
        private System.Windows.Forms.CheckBox cbNeg;
    }
}

