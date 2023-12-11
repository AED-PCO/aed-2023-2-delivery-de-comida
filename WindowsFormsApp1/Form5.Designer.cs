namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.Preco = new System.Windows.Forms.Label();
            this.buttonFNZ = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(890, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(242, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONCLUSÃO DE COMPRA";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(25, 532);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(119, 32);
            this.TOTAL.TabIndex = 7;
            this.TOTAL.Text = "TOTAL:\r\n";
            // 
            // Preco
            // 
            this.Preco.AutoSize = true;
            this.Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preco.ForeColor = System.Drawing.Color.White;
            this.Preco.Location = new System.Drawing.Point(173, 532);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(48, 32);
            this.Preco.TabIndex = 8;
            this.Preco.Text = "$$\r\n";
            this.Preco.Click += new System.EventHandler(this.preco);
            // 
            // buttonFNZ
            // 
            this.buttonFNZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFNZ.Location = new System.Drawing.Point(647, 505);
            this.buttonFNZ.Name = "buttonFNZ";
            this.buttonFNZ.Size = new System.Drawing.Size(203, 59);
            this.buttonFNZ.TabIndex = 9;
            this.buttonFNZ.Text = "FINALIZAR COMPRA\r\n";
            this.buttonFNZ.UseVisualStyleBackColor = false;
            this.buttonFNZ.Click += new System.EventHandler(this.Finalizar);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(159, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 201);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(889, 588);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonFNZ);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label Preco;
        private System.Windows.Forms.Button buttonFNZ;
        private System.Windows.Forms.ListView listView1;
    }
}