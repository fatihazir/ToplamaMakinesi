﻿namespace ToplamaMakinesiV
{
    partial class FormTopla
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabToplama = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabLoglama = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabToplama.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLoglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabToplama
            // 
            this.tabToplama.Controls.Add(this.tabPage1);
            this.tabToplama.Controls.Add(this.tabLoglama);
            this.tabToplama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabToplama.Location = new System.Drawing.Point(0, 0);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.SelectedIndex = 0;
            this.tabToplama.Size = new System.Drawing.Size(800, 450);
            this.tabToplama.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(124, 50);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(222, 22);
            this.txtBirinciSayi.TabIndex = 7;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBirinciSayi_KeyPress);
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(124, 76);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(222, 22);
            this.txtİkinciSayi.TabIndex = 8;
            this.txtİkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtİkinciSayi_KeyPress);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(160, 116);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(186, 40);
            this.btnTopla.TabIndex = 9;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(124, 174);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(222, 22);
            this.txtSonuc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSonuc);
            this.tabPage1.Controls.Add(this.btnTopla);
            this.tabPage1.Controls.Add(this.txtİkinciSayi);
            this.tabPage1.Controls.Add(this.txtBirinciSayi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Toplama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabLoglama
            // 
            this.tabLoglama.Controls.Add(this.listView1);
            this.tabLoglama.Location = new System.Drawing.Point(4, 25);
            this.tabLoglama.Name = "tabLoglama";
            this.tabLoglama.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoglama.Size = new System.Drawing.Size(792, 421);
            this.tabLoglama.TabIndex = 1;
            this.tabLoglama.Text = "Loglama";
            this.tabLoglama.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 415);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // FormTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabToplama);
            this.Name = "FormTopla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormTopla_Shown);
            this.tabToplama.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabLoglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabToplama;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabLoglama;
        private System.Windows.Forms.ListView listView1;
    }
}

