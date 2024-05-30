namespace HamburgerProject
{
    partial class SiparisOlusturEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlusturEkrani));
            gboxBoylar = new GroupBox();
            rbBuyuk = new RadioButton();
            rbOrta = new RadioButton();
            rbKucuk = new RadioButton();
            lblToplam = new Label();
            label4 = new Label();
            lboxSiparisler = new ListBox();
            btnSiparisOnay = new Button();
            btnEkle = new Button();
            nudAdet = new NumericUpDown();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            cboxMenu = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            gboxBoylar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gboxBoylar
            // 
            gboxBoylar.Controls.Add(rbBuyuk);
            gboxBoylar.Controls.Add(rbOrta);
            gboxBoylar.Controls.Add(rbKucuk);
            gboxBoylar.Location = new Point(7, 371);
            gboxBoylar.Margin = new Padding(1);
            gboxBoylar.Name = "gboxBoylar";
            gboxBoylar.Padding = new Padding(1);
            gboxBoylar.Size = new Size(191, 65);
            gboxBoylar.TabIndex = 48;
            gboxBoylar.TabStop = false;
            gboxBoylar.Text = "Boyu Seçiniz";
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(119, 29);
            rbBuyuk.Margin = new Padding(1);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(69, 24);
            rbBuyuk.TabIndex = 11;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(63, 29);
            rbOrta.Margin = new Padding(1);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(59, 24);
            rbOrta.TabIndex = 11;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(-1, 29);
            rbKucuk.Margin = new Padding(1);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(69, 24);
            rbKucuk.TabIndex = 11;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Red;
            lblToplam.Location = new Point(310, 467);
            lblToplam.Margin = new Padding(1, 0, 1, 0);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(72, 37);
            lblToplam.TabIndex = 47;
            lblToplam.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(237, 469);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 46;
            label4.Text = "Toplam";
            // 
            // lboxSiparisler
            // 
            lboxSiparisler.FormattingEnabled = true;
            lboxSiparisler.ItemHeight = 20;
            lboxSiparisler.Location = new Point(229, 13);
            lboxSiparisler.Margin = new Padding(1);
            lboxSiparisler.Name = "lboxSiparisler";
            lboxSiparisler.Size = new Size(551, 424);
            lboxSiparisler.TabIndex = 45;
            // 
            // btnSiparisOnay
            // 
            btnSiparisOnay.Location = new Point(581, 467);
            btnSiparisOnay.Margin = new Padding(1);
            btnSiparisOnay.Name = "btnSiparisOnay";
            btnSiparisOnay.Size = new Size(191, 55);
            btnSiparisOnay.TabIndex = 43;
            btnSiparisOnay.Text = "Siparişi Onayla";
            btnSiparisOnay.UseVisualStyleBackColor = true;
            btnSiparisOnay.Click += btnSiparisOnay_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(7, 485);
            btnEkle.Margin = new Padding(1);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(191, 36);
            btnEkle.TabIndex = 44;
            btnEkle.Text = "Siparişi Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(75, 444);
            nudAdet.Margin = new Padding(1);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(121, 27);
            nudAdet.TabIndex = 42;
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flpEkstraMalzemeler.Location = new Point(7, 219);
            flpEkstraMalzemeler.Margin = new Padding(1);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(191, 139);
            flpEkstraMalzemeler.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 197);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 39;
            label2.Text = "Ekstra Malzeme Seçiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 135);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 40;
            label1.Text = "Menu Seçiniz";
            // 
            // cboxMenu
            // 
            cboxMenu.FormattingEnabled = true;
            cboxMenu.Location = new Point(7, 157);
            cboxMenu.Margin = new Padding(1);
            cboxMenu.Name = "cboxMenu";
            cboxMenu.Size = new Size(191, 28);
            cboxMenu.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 13);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 446);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 49;
            label3.Text = "Adet:";
            // 
            // SiparisOlusturEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 531);
            Controls.Add(label3);
            Controls.Add(gboxBoylar);
            Controls.Add(lblToplam);
            Controls.Add(label4);
            Controls.Add(lboxSiparisler);
            Controls.Add(btnSiparisOnay);
            Controls.Add(btnEkle);
            Controls.Add(nudAdet);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboxMenu);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SiparisOlusturEkrani";
            Text = "SiparisOlusturEkrani";
            Load += SiparisOlusturEkrani_Load;
            gboxBoylar.ResumeLayout(false);
            gboxBoylar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxBoylar;
        private RadioButton rbBuyuk;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private Label lblToplam;
        private Label label4;
        private ListBox lboxSiparisler;
        private Button btnSiparisOnay;
        private Button btnEkle;
        private NumericUpDown nudAdet;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label2;
        private Label label1;
        private ComboBox cboxMenu;
        private PictureBox pictureBox1;
        private Label label3;
    }
}