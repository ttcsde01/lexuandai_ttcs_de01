
namespace ailatrieuphu_1
{
    partial class fnhanthuong
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
            this.pnthuong = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btneixtt = new System.Windows.Forms.Button();
            this.grbnhanthuong = new System.Windows.Forms.GroupBox();
            this.lbnhanthuong = new System.Windows.Forms.Label();
            this.pnthuong.SuspendLayout();
            this.grbnhanthuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnthuong
            // 
            this.pnthuong.Controls.Add(this.button1);
            this.pnthuong.Controls.Add(this.btneixtt);
            this.pnthuong.Controls.Add(this.grbnhanthuong);
            this.pnthuong.Location = new System.Drawing.Point(1, 2);
            this.pnthuong.Name = "pnthuong";
            this.pnthuong.Size = new System.Drawing.Size(796, 448);
            this.pnthuong.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(439, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kết Thúc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneixtt
            // 
            this.btneixtt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btneixtt.ForeColor = System.Drawing.Color.Red;
            this.btneixtt.Location = new System.Drawing.Point(124, 324);
            this.btneixtt.Name = "btneixtt";
            this.btneixtt.Size = new System.Drawing.Size(233, 84);
            this.btneixtt.TabIndex = 1;
            this.btneixtt.Text = "Chơi Lại";
            this.btneixtt.UseVisualStyleBackColor = true;
            this.btneixtt.Click += new System.EventHandler(this.btneixtt_Click);
            // 
            // grbnhanthuong
            // 
            this.grbnhanthuong.Controls.Add(this.lbnhanthuong);
            this.grbnhanthuong.Location = new System.Drawing.Point(34, 18);
            this.grbnhanthuong.Name = "grbnhanthuong";
            this.grbnhanthuong.Size = new System.Drawing.Size(733, 284);
            this.grbnhanthuong.TabIndex = 0;
            this.grbnhanthuong.TabStop = false;
            // 
            // lbnhanthuong
            // 
            this.lbnhanthuong.AutoSize = true;
            this.lbnhanthuong.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnhanthuong.ForeColor = System.Drawing.Color.Red;
            this.lbnhanthuong.Location = new System.Drawing.Point(-1, 106);
            this.lbnhanthuong.Name = "lbnhanthuong";
            this.lbnhanthuong.Size = new System.Drawing.Size(728, 55);
            this.lbnhanthuong.TabIndex = 0;
            this.lbnhanthuong.Text = "Chúc mừng bạn đã chiến thắng!!!!\r\n";
            // 
            // fnhanthuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnthuong);
            this.Name = "fnhanthuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận Thưởng";
          
            this.pnthuong.ResumeLayout(false);
            this.grbnhanthuong.ResumeLayout(false);
            this.grbnhanthuong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnthuong;
        private System.Windows.Forms.GroupBox grbnhanthuong;
        private System.Windows.Forms.Button btneixtt;
        private System.Windows.Forms.Label lbnhanthuong;
        private System.Windows.Forms.Button button1;
    }
}