namespace App
{
    partial class Thi
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cauhoi = new System.Windows.Forms.RichTextBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.macauhoi = new System.Windows.Forms.Label();
            this.cauA = new System.Windows.Forms.Label();
            this.cauB = new System.Windows.Forms.Label();
            this.cauC = new System.Windows.Forms.Label();
            this.cauD = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã câu :";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(489, 455);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 44);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = " Câu sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đáp án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Câu hỏi";
            // 
            // cauhoi
            // 
            this.cauhoi.Location = new System.Drawing.Point(74, 98);
            this.cauhoi.Margin = new System.Windows.Forms.Padding(4);
            this.cauhoi.Name = "cauhoi";
            this.cauhoi.ReadOnly = true;
            this.cauhoi.Size = new System.Drawing.Size(552, 117);
            this.cauhoi.TabIndex = 23;
            this.cauhoi.Text = "";
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxD.Location = new System.Drawing.Point(72, 409);
            this.checkBoxD.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(56, 35);
            this.checkBoxD.TabIndex = 18;
            this.checkBoxD.Text = "D";
            this.checkBoxD.UseVisualStyleBackColor = true;
            this.checkBoxD.CheckedChanged += new System.EventHandler(this.checkBoxD_CheckedChanged);
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxC.Location = new System.Drawing.Point(74, 361);
            this.checkBoxC.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(56, 35);
            this.checkBoxC.TabIndex = 17;
            this.checkBoxC.Text = "C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.CheckedChanged += new System.EventHandler(this.checkBoxC_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxB.Location = new System.Drawing.Point(74, 318);
            this.checkBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(54, 35);
            this.checkBoxB.TabIndex = 16;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.CheckedChanged += new System.EventHandler(this.checkBoxB_CheckedChanged);
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxA.Location = new System.Drawing.Point(74, 268);
            this.checkBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(54, 35);
            this.checkBoxA.TabIndex = 15;
            this.checkBoxA.Text = "A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            this.checkBoxA.CheckedChanged += new System.EventHandler(this.checkBoxA_CheckedChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(72, 455);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(137, 44);
            this.btnPrevious.TabIndex = 29;
            this.btnPrevious.Text = "Câu trước ";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // macauhoi
            // 
            this.macauhoi.AutoSize = true;
            this.macauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macauhoi.Location = new System.Drawing.Point(110, 22);
            this.macauhoi.Name = "macauhoi";
            this.macauhoi.Size = new System.Drawing.Size(81, 20);
            this.macauhoi.TabIndex = 30;
            this.macauhoi.Text = "macauhoi";
            // 
            // cauA
            // 
            this.cauA.AutoSize = true;
            this.cauA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauA.Location = new System.Drawing.Point(138, 277);
            this.cauA.Name = "cauA";
            this.cauA.Size = new System.Drawing.Size(20, 20);
            this.cauA.TabIndex = 31;
            this.cauA.Text = "A";
            // 
            // cauB
            // 
            this.cauB.AutoSize = true;
            this.cauB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauB.Location = new System.Drawing.Point(138, 328);
            this.cauB.Name = "cauB";
            this.cauB.Size = new System.Drawing.Size(21, 20);
            this.cauB.TabIndex = 32;
            this.cauB.Text = "B";
            // 
            // cauC
            // 
            this.cauC.AutoSize = true;
            this.cauC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauC.Location = new System.Drawing.Point(138, 371);
            this.cauC.Name = "cauC";
            this.cauC.Size = new System.Drawing.Size(21, 20);
            this.cauC.TabIndex = 33;
            this.cauC.Text = "C";
            // 
            // cauD
            // 
            this.cauD.AutoSize = true;
            this.cauD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauD.Location = new System.Drawing.Point(138, 419);
            this.cauD.Name = "cauD";
            this.cauD.Size = new System.Drawing.Size(22, 20);
            this.cauD.TabIndex = 34;
            this.cauD.Text = "D";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(489, 25);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 44);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 525);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cauD);
            this.Controls.Add(this.cauC);
            this.Controls.Add(this.cauB);
            this.Controls.Add(this.cauA);
            this.Controls.Add(this.macauhoi);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cauhoi);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Name = "Thi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.Thi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox cauhoi;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label macauhoi;
        private System.Windows.Forms.Label cauA;
        private System.Windows.Forms.Label cauB;
        private System.Windows.Forms.Label cauC;
        private System.Windows.Forms.Label cauD;
        private System.Windows.Forms.Button btnSubmit;
    }
}