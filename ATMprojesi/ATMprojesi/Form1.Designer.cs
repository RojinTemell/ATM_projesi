
namespace ATMprojesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gonderbtn = new System.Windows.Forms.Button();
            this.sifretxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciaditxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXbank = new System.Windows.Forms.RadioButton();
            this.btnYbank = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gonderbtn);
            this.groupBox1.Controls.Add(this.sifretxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kullaniciaditxtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(92, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Ekranı";
            // 
            // gonderbtn
            // 
            this.gonderbtn.Location = new System.Drawing.Point(156, 164);
            this.gonderbtn.Name = "gonderbtn";
            this.gonderbtn.Size = new System.Drawing.Size(96, 37);
            this.gonderbtn.TabIndex = 4;
            this.gonderbtn.Text = "Gönder";
            this.gonderbtn.UseVisualStyleBackColor = true;
            this.gonderbtn.Click += new System.EventHandler(this.gonderbtn_Click);
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.Location = new System.Drawing.Point(140, 98);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.Size = new System.Drawing.Size(159, 27);
            this.sifretxtbox.TabIndex = 3;
            this.sifretxtbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "sifre:";
            // 
            // kullaniciaditxtbox
            // 
            this.kullaniciaditxtbox.Location = new System.Drawing.Point(140, 51);
            this.kullaniciaditxtbox.Name = "kullaniciaditxtbox";
            this.kullaniciaditxtbox.Size = new System.Drawing.Size(159, 27);
            this.kullaniciaditxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı adı:";
            // 
            // btnXbank
            // 
            this.btnXbank.AutoSize = true;
            this.btnXbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXbank.Location = new System.Drawing.Point(154, 59);
            this.btnXbank.Name = "btnXbank";
            this.btnXbank.Size = new System.Drawing.Size(81, 24);
            this.btnXbank.TabIndex = 1;
            this.btnXbank.TabStop = true;
            this.btnXbank.Text = "Xbank";
            this.btnXbank.UseVisualStyleBackColor = true;
            // 
            // btnYbank
            // 
            this.btnYbank.AutoSize = true;
            this.btnYbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYbank.Location = new System.Drawing.Point(311, 59);
            this.btnYbank.Name = "btnYbank";
            this.btnYbank.Size = new System.Drawing.Size(80, 24);
            this.btnYbank.TabIndex = 2;
            this.btnYbank.TabStop = true;
            this.btnYbank.Text = "Ybank";
            this.btnYbank.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(611, 440);
            this.Controls.Add(this.btnYbank);
            this.Controls.Add(this.btnXbank);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button gonderbtn;
        private System.Windows.Forms.TextBox sifretxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciaditxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnXbank;
        private System.Windows.Forms.RadioButton btnYbank;
    }
}

