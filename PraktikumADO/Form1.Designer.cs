namespace PraktikumADO
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
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMk = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHitungDosen = new System.Windows.Forms.Button();
            this.btnUpdateMK = new System.Windows.Forms.Button();
            this.btnInsertProdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(383, 114);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(558, 33);
            this.txtHasil.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(275, 114);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Hasil";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(163, 370);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 39);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(383, 371);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(136, 38);
            this.btnHitungMhs.TabIndex = 3;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMk
            // 
            this.btnHitungMk.Location = new System.Drawing.Point(665, 371);
            this.btnHitungMk.Name = "btnHitungMk";
            this.btnHitungMk.Size = new System.Drawing.Size(129, 38);
            this.btnHitungMk.TabIndex = 4;
            this.btnHitungMk.Text = "Hitung Mk";
            this.btnHitungMk.UseVisualStyleBackColor = true;
            this.btnHitungMk.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(933, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHitungDosen
            // 
            this.btnHitungDosen.Location = new System.Drawing.Point(331, 482);
            this.btnHitungDosen.Name = "btnHitungDosen";
            this.btnHitungDosen.Size = new System.Drawing.Size(133, 44);
            this.btnHitungDosen.TabIndex = 6;
            this.btnHitungDosen.Text = "Hitung Dosen";
            this.btnHitungDosen.UseVisualStyleBackColor = true;
            this.btnHitungDosen.Click += new System.EventHandler(this.btnHitungDosen_Click);
            // 
            // btnUpdateMK
            // 
            this.btnUpdateMK.Location = new System.Drawing.Point(602, 478);
            this.btnUpdateMK.Name = "btnUpdateMK";
            this.btnUpdateMK.Size = new System.Drawing.Size(156, 48);
            this.btnUpdateMK.TabIndex = 7;
            this.btnUpdateMK.Text = "Update Mk";
            this.btnUpdateMK.UseVisualStyleBackColor = true;
            this.btnUpdateMK.Click += new System.EventHandler(this.btnUpdateMK_Click);
            // 
            // btnInsertProdi
            // 
            this.btnInsertProdi.Location = new System.Drawing.Point(865, 482);
            this.btnInsertProdi.Name = "btnInsertProdi";
            this.btnInsertProdi.Size = new System.Drawing.Size(149, 43);
            this.btnInsertProdi.TabIndex = 8;
            this.btnInsertProdi.Text = "Insert Prodi";
            this.btnInsertProdi.UseVisualStyleBackColor = true;
            this.btnInsertProdi.Click += new System.EventHandler(this.btnInsertProdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 625);
            this.Controls.Add(this.btnInsertProdi);
            this.Controls.Add(this.btnUpdateMK);
            this.Controls.Add(this.btnHitungDosen);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMk);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtHasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHitungDosen;
        private System.Windows.Forms.Button btnUpdateMK;
        private System.Windows.Forms.Button btnInsertProdi;
    }
}

