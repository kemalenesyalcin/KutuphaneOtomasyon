namespace KutuphaneOtomasyon
{
    partial class UyeSayfasi
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
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_kitapID = new System.Windows.Forms.TextBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(29, 24);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_kitapID
            // 
            this.txt_kitapID.Location = new System.Drawing.Point(110, 25);
            this.txt_kitapID.Name = "txt_kitapID";
            this.txt_kitapID.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapID.TabIndex = 1;
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(216, 24);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(29, 319);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 23);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfa,
            this.basimyili});
            this.dataGridView1.Location = new System.Drawing.Point(29, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(777, 201);
            this.dataGridView1.TabIndex = 4;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAPİD";
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 80;
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "KİTAP İSİM";
            this.kitapisim.Name = "kitapisim";
            this.kitapisim.Width = 80;
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "KİTAP YAZAR";
            this.kitapyazar.Name = "kitapyazar";
            this.kitapyazar.Width = 80;
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "KİTAP DİLİ";
            this.kitapdili.Name = "kitapdili";
            this.kitapdili.Width = 80;
            // 
            // yayinevi
            // 
            this.yayinevi.HeaderText = "YAYIN EVİ";
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Width = 80;
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.Name = "tur";
            this.tur.Width = 80;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            this.adet.Width = 80;
            // 
            // sayfa
            // 
            this.sayfa.HeaderText = "SAYFA";
            this.sayfa.Name = "sayfa";
            this.sayfa.Width = 80;
            // 
            // basimyili
            // 
            this.basimyili.HeaderText = "BASIM YILI";
            this.basimyili.Name = "basimyili";
            this.basimyili.Width = 80;
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txt_kitapID);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ara);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_kitapID;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
    }
}