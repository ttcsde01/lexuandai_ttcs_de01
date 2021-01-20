
namespace ailatrieuphu_1
{
    partial class fmain
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
            this.pnmain = new System.Windows.Forms.Panel();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.pnmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnmain
            // 
            this.pnmain.Controls.Add(this.btncapnhat);
            this.pnmain.Controls.Add(this.btnexit);
            this.pnmain.Controls.Add(this.btninfo);
            this.pnmain.Controls.Add(this.btnplay);
            this.pnmain.Location = new System.Drawing.Point(12, 12);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(874, 537);
            this.pnmain.TabIndex = 0;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncapnhat.Location = new System.Drawing.Point(268, 271);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(308, 114);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnexit.Location = new System.Drawing.Point(292, 426);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(243, 96);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btninfo
            // 
            this.btninfo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btninfo.Location = new System.Drawing.Point(498, 41);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(306, 201);
            this.btninfo.TabIndex = 1;
            this.btninfo.Text = "Thông Tin";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnplay.Location = new System.Drawing.Point(62, 41);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(306, 201);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "Bắt Đầu";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmain
            // 
            this.AcceptButton = this.btnplay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(898, 561);
            this.Controls.Add(this.pnmain);
            this.Name = "fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng đến với game ai là triệu phú";
            this.pnmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnmain;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btncapnhat;
    }
}

