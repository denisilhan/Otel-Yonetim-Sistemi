using System;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    partial class RezervasyonController
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewRezervasyon;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.DataGridView dataGridViewOda;
        private System.Windows.Forms.TextBox txtOdaNumara;
        private System.Windows.Forms.TextBox txtMusteriTCKimlik;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnRezervasyonIptal;
        private System.Windows.Forms.Button btnRezervasyonTemizle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRezervasyon = new System.Windows.Forms.DataGridView();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.dataGridViewOda = new System.Windows.Forms.DataGridView();
            this.txtOdaNumara = new System.Windows.Forms.TextBox();
            this.txtMusteriTCKimlik = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnRezervasyonIptal = new System.Windows.Forms.Button();
            this.btnRezervasyonTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdaNumarasi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOda)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRezervasyon
            // 
            this.dataGridViewRezervasyon.AllowUserToAddRows = false;
            this.dataGridViewRezervasyon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewRezervasyon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewRezervasyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRezervasyon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRezervasyon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRezervasyon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRezervasyon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRezervasyon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRezervasyon.ColumnHeadersHeight = 29;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRezervasyon.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewRezervasyon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewRezervasyon.EnableHeadersVisualStyles = false;
            this.dataGridViewRezervasyon.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewRezervasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRezervasyon.MultiSelect = false;
            this.dataGridViewRezervasyon.Name = "dataGridViewRezervasyon";
            this.dataGridViewRezervasyon.ReadOnly = true;
            this.dataGridViewRezervasyon.RowHeadersVisible = false;
            this.dataGridViewRezervasyon.RowHeadersWidth = 51;
            this.dataGridViewRezervasyon.RowTemplate.Height = 35;
            this.dataGridViewRezervasyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRezervasyon.Size = new System.Drawing.Size(780, 170);
            this.dataGridViewRezervasyon.TabIndex = 0;
            this.dataGridViewRezervasyon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRezervasyon_CellClick);
            this.dataGridViewRezervasyon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRezervasyon_CellContentClick);
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.AllowUserToAddRows = false;
            this.dataGridViewMusteri.AllowUserToDeleteRows = false;
            this.dataGridViewMusteri.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewMusteri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteri.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMusteri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMusteri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMusteri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusteri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewMusteri.ColumnHeadersHeight = 30;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMusteri.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewMusteri.EnableHeadersVisualStyles = false;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(400, 185);
            this.dataGridViewMusteri.MultiSelect = false;
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.ReadOnly = true;
            this.dataGridViewMusteri.RowHeadersVisible = false;
            this.dataGridViewMusteri.RowHeadersWidth = 51;
            this.dataGridViewMusteri.RowTemplate.Height = 35;
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(390, 172);
            this.dataGridViewMusteri.TabIndex = 0;
            // 
            // dataGridViewOda
            // 
            this.dataGridViewOda.AllowUserToAddRows = false;
            this.dataGridViewOda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewOda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewOda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewOda.ColumnHeadersHeight = 29;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOda.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewOda.EnableHeadersVisualStyles = false;
            this.dataGridViewOda.Location = new System.Drawing.Point(10, 185);
            this.dataGridViewOda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOda.MultiSelect = false;
            this.dataGridViewOda.Name = "dataGridViewOda";
            this.dataGridViewOda.ReadOnly = true;
            this.dataGridViewOda.RowHeadersVisible = false;
            this.dataGridViewOda.RowHeadersWidth = 51;
            this.dataGridViewOda.RowTemplate.Height = 35;
            this.dataGridViewOda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOda.Size = new System.Drawing.Size(384, 174);
            this.dataGridViewOda.TabIndex = 0;
            this.dataGridViewOda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOda_CellClick);
            this.dataGridViewOda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOda_CellContentClick);
            // 
            // txtOdaNumara
            // 
            this.txtOdaNumara.Location = new System.Drawing.Point(13, 78);
            this.txtOdaNumara.Multiline = true;
            this.txtOdaNumara.Name = "txtOdaNumara";
            this.txtOdaNumara.Size = new System.Drawing.Size(120, 24);
            this.txtOdaNumara.TabIndex = 3;
            // 
            // txtMusteriTCKimlik
            // 
            this.txtMusteriTCKimlik.Location = new System.Drawing.Point(13, 30);
            this.txtMusteriTCKimlik.Multiline = true;
            this.txtMusteriTCKimlik.Name = "txtMusteriTCKimlik";
            this.txtMusteriTCKimlik.Size = new System.Drawing.Size(120, 24);
            this.txtMusteriTCKimlik.TabIndex = 4;
            this.txtMusteriTCKimlik.TextChanged += new System.EventHandler(this.txtMusteriTCKimlik_TextChanged);
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(143, 30);
            this.txtDurum.Multiline = true;
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(120, 24);
            this.txtDurum.TabIndex = 5;
            // 
            // dateGiris
            // 
            this.dateGiris.Location = new System.Drawing.Point(272, 28);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(169, 22);
            this.dateGiris.TabIndex = 6;
            this.dateGiris.ValueChanged += new System.EventHandler(this.dateGiris_ValueChanged);
            // 
            // dateCikis
            // 
            this.dateCikis.Location = new System.Drawing.Point(272, 76);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(169, 22);
            this.dateCikis.TabIndex = 7;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(447, 28);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(100, 45);
            this.btnRezervasyonYap.TabIndex = 8;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnRezervasyonIptal
            // 
            this.btnRezervasyonIptal.BackColor = System.Drawing.Color.DimGray;
            this.btnRezervasyonIptal.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonIptal.Location = new System.Drawing.Point(553, 28);
            this.btnRezervasyonIptal.Name = "btnRezervasyonIptal";
            this.btnRezervasyonIptal.Size = new System.Drawing.Size(100, 45);
            this.btnRezervasyonIptal.TabIndex = 9;
            this.btnRezervasyonIptal.Text = "Rezervasyon İptal";
            this.btnRezervasyonIptal.UseVisualStyleBackColor = false;
            this.btnRezervasyonIptal.Click += new System.EventHandler(this.btnRezervasyonIptal_Click);
            // 
            // btnRezervasyonTemizle
            // 
            this.btnRezervasyonTemizle.BackColor = System.Drawing.Color.Red;
            this.btnRezervasyonTemizle.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonTemizle.Location = new System.Drawing.Point(659, 28);
            this.btnRezervasyonTemizle.Name = "btnRezervasyonTemizle";
            this.btnRezervasyonTemizle.Size = new System.Drawing.Size(100, 45);
            this.btnRezervasyonTemizle.TabIndex = 10;
            this.btnRezervasyonTemizle.Text = "Temizle";
            this.btnRezervasyonTemizle.UseVisualStyleBackColor = false;
            this.btnRezervasyonTemizle.Click += new System.EventHandler(this.btnRezervasyonTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "TC Kimlik:";
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.AutoSize = true;
            this.txtOdaNumarasi.Location = new System.Drawing.Point(13, 57);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(97, 16);
            this.txtOdaNumarasi.TabIndex = 17;
            this.txtOdaNumarasi.Text = "Oda Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Durum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Çıkış Tarihi:";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bottomPanel.Controls.Add(this.label4);
            this.bottomPanel.Controls.Add(this.label3);
            this.bottomPanel.Controls.Add(this.label2);
            this.bottomPanel.Controls.Add(this.btnRezervasyonTemizle);
            this.bottomPanel.Controls.Add(this.dateCikis);
            this.bottomPanel.Controls.Add(this.btnRezervasyonIptal);
            this.bottomPanel.Controls.Add(this.dateGiris);
            this.bottomPanel.Controls.Add(this.btnRezervasyonYap);
            this.bottomPanel.Controls.Add(this.txtOdaNumarasi);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.txtDurum);
            this.bottomPanel.Controls.Add(this.txtMusteriTCKimlik);
            this.bottomPanel.Controls.Add(this.txtOdaNumara);
            this.bottomPanel.Location = new System.Drawing.Point(12, 363);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(780, 124);
            this.bottomPanel.TabIndex = 1;
            // 
            // RezervasyonController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dataGridViewRezervasyon);
            this.Controls.Add(this.dataGridViewOda);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Controls.Add(this.bottomPanel);
            this.Name = "RezervasyonController";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOda)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label txtOdaNumarasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bottomPanel;
    }
}