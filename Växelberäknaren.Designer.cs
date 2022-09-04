namespace L0002B_Uppgift_1_Windows_Forms_App_.NET
{
    partial class Växelberäknaren
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
            this.beräknaVäxel = new System.Windows.Forms.Button();
            this.avsluta = new System.Windows.Forms.Button();
            this.välkommenStart = new System.Windows.Forms.Label();
            this.prisFält = new System.Windows.Forms.TextBox();
            this.betalatFält = new System.Windows.Forms.TextBox();
            this.prisText = new System.Windows.Forms.Label();
            this.betalatText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beräknaVäxel
            // 
            this.beräknaVäxel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.beräknaVäxel.Location = new System.Drawing.Point(605, 403);
            this.beräknaVäxel.Name = "beräknaVäxel";
            this.beräknaVäxel.Size = new System.Drawing.Size(183, 35);
            this.beräknaVäxel.TabIndex = 1;
            this.beräknaVäxel.Text = "Beräkna växel";
            this.beräknaVäxel.UseVisualStyleBackColor = true;
            this.beräknaVäxel.Click += new System.EventHandler(this.knappBeräknaVäxel_Klick);
            // 
            // avsluta
            // 
            this.avsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avsluta.Location = new System.Drawing.Point(12, 403);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(102, 35);
            this.avsluta.TabIndex = 2;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = true;
            this.avsluta.Click += new System.EventHandler(this.knappAvsluta_Klick);
            // 
            // välkommenStart
            // 
            this.välkommenStart.AutoSize = true;
            this.välkommenStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.välkommenStart.Location = new System.Drawing.Point(202, 99);
            this.välkommenStart.Name = "välkommenStart";
            this.välkommenStart.Size = new System.Drawing.Size(408, 31);
            this.välkommenStart.TabIndex = 3;
            this.välkommenStart.Text = "Välkommen till Växelberäknaren!";
            // 
            // prisFält
            // 
            this.prisFält.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.prisFält.Location = new System.Drawing.Point(350, 189);
            this.prisFält.Name = "prisFält";
            this.prisFält.Size = new System.Drawing.Size(100, 26);
            this.prisFält.TabIndex = 4;
            // 
            // betalatFält
            // 
            this.betalatFält.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.betalatFält.Location = new System.Drawing.Point(350, 249);
            this.betalatFält.Name = "betalatFält";
            this.betalatFält.Size = new System.Drawing.Size(100, 26);
            this.betalatFält.TabIndex = 5;
            // 
            // prisText
            // 
            this.prisText.AutoSize = true;
            this.prisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.prisText.Location = new System.Drawing.Point(206, 195);
            this.prisText.Name = "prisText";
            this.prisText.Size = new System.Drawing.Size(44, 20);
            this.prisText.TabIndex = 6;
            this.prisText.Text = "Pris:";
            // 
            // betalatText
            // 
            this.betalatText.AutoSize = true;
            this.betalatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.betalatText.Location = new System.Drawing.Point(206, 252);
            this.betalatText.Name = "betalatText";
            this.betalatText.Size = new System.Drawing.Size(121, 20);
            this.betalatText.TabIndex = 7;
            this.betalatText.Text = "Betalat belopp:";
            // 
            // Växelberäknaren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betalatText);
            this.Controls.Add(this.prisText);
            this.Controls.Add(this.betalatFält);
            this.Controls.Add(this.prisFält);
            this.Controls.Add(this.välkommenStart);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.beräknaVäxel);
            this.Name = "Växelberäknaren";
            this.Text = "Växelberäknaren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button beräknaVäxel;
        private System.Windows.Forms.Button avsluta;
        private System.Windows.Forms.Label välkommenStart;
        private System.Windows.Forms.TextBox prisFält;
        private System.Windows.Forms.TextBox betalatFält;
        private System.Windows.Forms.Label prisText;
        private System.Windows.Forms.Label betalatText;
    }
}

