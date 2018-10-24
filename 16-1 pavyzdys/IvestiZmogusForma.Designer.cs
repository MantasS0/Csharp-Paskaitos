namespace _16_1_pavyzdys
{
    partial class IvestiZmogusForma
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
            this.textBoxVardas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProfesija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmzius = new System.Windows.Forms.TextBox();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.buttoAtsaukti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ivesti Varda";
            // 
            // textBoxVardas
            // 
            this.textBoxVardas.Location = new System.Drawing.Point(135, 102);
            this.textBoxVardas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxVardas.Name = "textBoxVardas";
            this.textBoxVardas.Size = new System.Drawing.Size(264, 26);
            this.textBoxVardas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ivesti Profesija";
            // 
            // textBoxProfesija
            // 
            this.textBoxProfesija.Location = new System.Drawing.Point(135, 314);
            this.textBoxProfesija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProfesija.Name = "textBoxProfesija";
            this.textBoxProfesija.Size = new System.Drawing.Size(264, 26);
            this.textBoxProfesija.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ivesti Amziu";
            // 
            // textBoxAmzius
            // 
            this.textBoxAmzius.Location = new System.Drawing.Point(135, 205);
            this.textBoxAmzius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAmzius.Name = "textBoxAmzius";
            this.textBoxAmzius.Size = new System.Drawing.Size(264, 26);
            this.textBoxAmzius.TabIndex = 1;
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(135, 404);
            this.buttonGerai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(130, 32);
            this.buttonGerai.TabIndex = 2;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.buttonGerai_Click);
            // 
            // buttoAtsaukti
            // 
            this.buttoAtsaukti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttoAtsaukti.Location = new System.Drawing.Point(270, 404);
            this.buttoAtsaukti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttoAtsaukti.Name = "buttoAtsaukti";
            this.buttoAtsaukti.Size = new System.Drawing.Size(130, 32);
            this.buttoAtsaukti.TabIndex = 2;
            this.buttoAtsaukti.Text = "Atsaukti";
            this.buttoAtsaukti.UseVisualStyleBackColor = true;
            // 
            // IvestiZmogusForma
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.buttoAtsaukti;
            this.ClientSize = new System.Drawing.Size(543, 541);
            this.Controls.Add(this.buttoAtsaukti);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.textBoxAmzius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProfesija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVardas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IvestiZmogusForma";
            this.ShowIcon = false;
            this.Text = "IvestiZmogusForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVardas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProfesija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmzius;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.Button buttoAtsaukti;
    }
}