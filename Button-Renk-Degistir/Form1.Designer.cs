namespace Button_Renk_Degistir
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.BackColor = System.Drawing.Color.Red;
            this.btnKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirmizi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKirmizi.Location = new System.Drawing.Point(39, 34);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(137, 63);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "Kırmızı";
            this.btnKirmizi.UseVisualStyleBackColor = false;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.Blue;
            this.btnMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMavi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMavi.Location = new System.Drawing.Point(182, 34);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(137, 63);
            this.btnMavi.TabIndex = 1;
            this.btnMavi.Text = "Mavi";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnKirmizi);
            this.Name = "Form1";
            this.Text = "Button ile Renk Değiştirme Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnMavi;
    }
}

