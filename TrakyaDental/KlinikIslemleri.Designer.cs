﻿namespace TrakyaDental
{
    partial class KlinikIslemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlinikIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSMSveEmail = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRandevuDefteri = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPersonelBilgileri = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.personelBilgileri1 = new TrakyaDental.PersonelBilgileri();
            this.smSveEmailIslemleri1 = new TrakyaDental.SMSveEmailIslemleri();
            this.randevuDefteri1 = new TrakyaDental.RandevuDefteri();
            this.blue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSMSveEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRandevuDefteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonelBilgileri)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1056, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1087, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(16, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(373, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "TRAKYA DENTAL - Dental Klinik Çözümleri";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pbSMSveEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbRandevuDefteri);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbPersonelBilgileri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 599);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SMS ve E-mail İşlemleri";
            // 
            // pbSMSveEmail
            // 
            this.pbSMSveEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbSMSveEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSMSveEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSMSveEmail.InitialImage = null;
            this.pbSMSveEmail.Location = new System.Drawing.Point(8, 136);
            this.pbSMSveEmail.Name = "pbSMSveEmail";
            this.pbSMSveEmail.Size = new System.Drawing.Size(215, 46);
            this.pbSMSveEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSMSveEmail.TabIndex = 4;
            this.pbSMSveEmail.TabStop = false;
            this.pbSMSveEmail.Click += new System.EventHandler(this.pbSMSveEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Randevu Defteri";
            // 
            // pbRandevuDefteri
            // 
            this.pbRandevuDefteri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbRandevuDefteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbRandevuDefteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRandevuDefteri.InitialImage = null;
            this.pbRandevuDefteri.Location = new System.Drawing.Point(8, 77);
            this.pbRandevuDefteri.Name = "pbRandevuDefteri";
            this.pbRandevuDefteri.Size = new System.Drawing.Size(215, 46);
            this.pbRandevuDefteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRandevuDefteri.TabIndex = 2;
            this.pbRandevuDefteri.TabStop = false;
            this.pbRandevuDefteri.Click += new System.EventHandler(this.pbRandevuDefteri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Bilgileri";
            // 
            // pbPersonelBilgileri
            // 
            this.pbPersonelBilgileri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbPersonelBilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPersonelBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonelBilgileri.InitialImage = null;
            this.pbPersonelBilgileri.Location = new System.Drawing.Point(8, 19);
            this.pbPersonelBilgileri.Name = "pbPersonelBilgileri";
            this.pbPersonelBilgileri.Size = new System.Drawing.Size(215, 46);
            this.pbPersonelBilgileri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonelBilgileri.TabIndex = 0;
            this.pbPersonelBilgileri.TabStop = false;
            this.pbPersonelBilgileri.Click += new System.EventHandler(this.pbPersonelBilgileri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.personelBilgileri1);
            this.panel3.Controls.Add(this.smSveEmailIslemleri1);
            this.panel3.Controls.Add(this.randevuDefteri1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(235, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 599);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(229, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 599);
            this.panel4.TabIndex = 3;
            // 
            // personelBilgileri1
            // 
            this.personelBilgileri1.Location = new System.Drawing.Point(3, 0);
            this.personelBilgileri1.Name = "personelBilgileri1";
            this.personelBilgileri1.Size = new System.Drawing.Size(883, 578);
            this.personelBilgileri1.TabIndex = 3;
            // 
            // smSveEmailIslemleri1
            // 
            this.smSveEmailIslemleri1.Location = new System.Drawing.Point(4, 0);
            this.smSveEmailIslemleri1.Name = "smSveEmailIslemleri1";
            this.smSveEmailIslemleri1.Size = new System.Drawing.Size(873, 578);
            this.smSveEmailIslemleri1.TabIndex = 2;
            // 
            // randevuDefteri1
            // 
            this.randevuDefteri1.Location = new System.Drawing.Point(3, 0);
            this.randevuDefteri1.Name = "randevuDefteri1";
            this.randevuDefteri1.Size = new System.Drawing.Size(883, 578);
            this.randevuDefteri1.TabIndex = 0;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.blue.Enabled = false;
            this.blue.FlatAppearance.BorderSize = 0;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blue.Location = new System.Drawing.Point(209, 19);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(14, 46);
            this.blue.TabIndex = 12;
            this.blue.UseVisualStyleBackColor = false;
            // 
            // KlinikIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1124, 645);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KlinikIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KlinikIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSMSveEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRandevuDefteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonelBilgileri)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPersonelBilgileri;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSMSveEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbRandevuDefteri;
        private RandevuDefteri randevuDefteri1;
        private SMSveEmailIslemleri smSveEmailIslemleri1;
        private PersonelBilgileri personelBilgileri1;
        private System.Windows.Forms.Button blue;
    }
}

