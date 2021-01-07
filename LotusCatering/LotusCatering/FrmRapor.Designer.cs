
namespace LotusCatering
{
    partial class FrmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnMenuler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFatura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMusteriler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMusteriler.Location = new System.Drawing.Point(12, 101);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(178, 35);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "MÜŞTERİLERİMİZ";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiparisler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisler.Location = new System.Drawing.Point(237, 101);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(178, 35);
            this.btnSiparisler.TabIndex = 2;
            this.btnSiparisler.Text = "SİPARİŞLER";
            this.btnSiparisler.UseVisualStyleBackColor = false;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnMenuler
            // 
            this.btnMenuler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMenuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuler.Location = new System.Drawing.Point(465, 101);
            this.btnMenuler.Name = "btnMenuler";
            this.btnMenuler.Size = new System.Drawing.Size(178, 35);
            this.btnMenuler.TabIndex = 3;
            this.btnMenuler.Text = "MENÜLERİMİZ";
            this.btnMenuler.UseVisualStyleBackColor = false;
            this.btnMenuler.Click += new System.EventHandler(this.btnMenuler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 262);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOTUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(421, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "CATERING";
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFatura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.Location = new System.Drawing.Point(690, 101);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(178, 35);
            this.btnFatura.TabIndex = 7;
            this.btnFatura.Text = "FATURALAR";
            this.btnFatura.UseVisualStyleBackColor = false;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 441);
            this.Controls.Add(this.btnFatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenuler);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.btnMusteriler);
            this.Name = "FrmRapor";
            this.Text = "LOTUS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnMenuler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFatura;
    }
}