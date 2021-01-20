
namespace ailatrieuphu_1
{
    partial class finfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbgv = new System.Windows.Forms.Label();
            this.lbssv = new System.Windows.Forms.Label();
            this.lbsv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnex = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbgv);
            this.panel1.Controls.Add(this.lbssv);
            this.panel1.Controls.Add(this.lbsv);
            this.panel1.Location = new System.Drawing.Point(27, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 226);
            this.panel1.TabIndex = 0;
           
            // 
            // lbgv
            // 
            this.lbgv.AutoSize = true;
            this.lbgv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbgv.ForeColor = System.Drawing.Color.Red;
            this.lbgv.Location = new System.Drawing.Point(3, 9);
            this.lbgv.Name = "lbgv";
            this.lbgv.Size = new System.Drawing.Size(442, 36);
            this.lbgv.TabIndex = 2;
            this.lbgv.Text = "*GVHD: Thầy Mai Cường Thọ";
            // 
            // lbssv
            // 
            this.lbssv.AutoSize = true;
            this.lbssv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbssv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbssv.Location = new System.Drawing.Point(2, 56);
            this.lbssv.Name = "lbssv";
            this.lbssv.Size = new System.Drawing.Size(289, 37);
            this.lbssv.TabIndex = 1;
            this.lbssv.Text = "*Sinh viên thực hiện:";
            // 
            // lbsv
            // 
            this.lbsv.AutoSize = true;
            this.lbsv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsv.Location = new System.Drawing.Point(3, 106);
            this.lbsv.Name = "lbsv";
            this.lbsv.Size = new System.Drawing.Size(271, 96);
            this.lbsv.TabIndex = 0;
            this.lbsv.Text = "-Lê Xuân Đại\r\n-Võ Lương Sỹ Hoàng\r\n*60-CNTT3";
        
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 94);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Đồ án lập trình game Ai là triệu phú";
            // 
            // btnex
            // 
            this.btnex.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnex.Location = new System.Drawing.Point(620, 391);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(168, 47);
            this.btnex.TabIndex = 2;
            this.btnex.Text = "Quay lại";
            this.btnex.UseVisualStyleBackColor = true;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // finfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnex;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "finfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên thực hiện";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsv;
        private System.Windows.Forms.Label lbgv;
        private System.Windows.Forms.Label lbssv;
        private System.Windows.Forms.Button btnex;
    }
}