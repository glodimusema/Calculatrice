﻿namespace Calculatrice
{
    partial class Calculatrice
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtReponse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Reponse :";
            // 
            // txtReponse
            // 
            this.txtReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReponse.Location = new System.Drawing.Point(201, 381);
            this.txtReponse.Name = "txtReponse";
            this.txtReponse.Size = new System.Drawing.Size(233, 35);
            this.txtReponse.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "CALCULER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre2 ";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre2.Location = new System.Drawing.Point(201, 158);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(233, 35);
            this.txtNombre2.TabIndex = 11;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre1.Location = new System.Drawing.Point(201, 103);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(233, 35);
            this.txtNombre1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "CALCULATRICE";
            // 
            // txtSigne
            // 
            this.txtSigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSigne.FormattingEnabled = true;
            this.txtSigne.Items.AddRange(new object[] {
            "+",
            "-",
            "X",
            ":",
            "%"});
            this.txtSigne.Location = new System.Drawing.Point(201, 231);
            this.txtSigne.Name = "txtSigne";
            this.txtSigne.Size = new System.Drawing.Size(233, 28);
            this.txtSigne.TabIndex = 16;
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 508);
            this.Controls.Add(this.txtSigne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReponse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtSigne;
    }
}