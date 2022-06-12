namespace SQLite_Quiz_GUI
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
            this.radioButton_A = new System.Windows.Forms.RadioButton();
            this.radioButton_B = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.radioButton_D = new System.Windows.Forms.RadioButton();
            this.label_Question = new System.Windows.Forms.Label();
            this.button_NewQuestion = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_A
            // 
            this.radioButton_A.AutoSize = true;
            this.radioButton_A.Checked = true;
            this.radioButton_A.Location = new System.Drawing.Point(90, 65);
            this.radioButton_A.Name = "radioButton_A";
            this.radioButton_A.Size = new System.Drawing.Size(32, 17);
            this.radioButton_A.TabIndex = 0;
            this.radioButton_A.TabStop = true;
            this.radioButton_A.Text = "A";
            this.radioButton_A.UseVisualStyleBackColor = true;
            // 
            // radioButton_B
            // 
            this.radioButton_B.AutoSize = true;
            this.radioButton_B.Location = new System.Drawing.Point(90, 89);
            this.radioButton_B.Name = "radioButton_B";
            this.radioButton_B.Size = new System.Drawing.Size(32, 17);
            this.radioButton_B.TabIndex = 1;
            this.radioButton_B.TabStop = true;
            this.radioButton_B.Text = "B";
            this.radioButton_B.UseVisualStyleBackColor = true;
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Location = new System.Drawing.Point(90, 113);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(32, 17);
            this.radioButton_C.TabIndex = 2;
            this.radioButton_C.TabStop = true;
            this.radioButton_C.Text = "C";
            this.radioButton_C.UseVisualStyleBackColor = true;
            // 
            // radioButton_D
            // 
            this.radioButton_D.AutoSize = true;
            this.radioButton_D.Location = new System.Drawing.Point(90, 137);
            this.radioButton_D.Name = "radioButton_D";
            this.radioButton_D.Size = new System.Drawing.Size(33, 17);
            this.radioButton_D.TabIndex = 3;
            this.radioButton_D.TabStop = true;
            this.radioButton_D.Text = "D";
            this.radioButton_D.UseVisualStyleBackColor = true;
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Location = new System.Drawing.Point(87, 34);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(35, 13);
            this.label_Question.TabIndex = 4;
            this.label_Question.Text = "label1";
            // 
            // button_NewQuestion
            // 
            this.button_NewQuestion.Location = new System.Drawing.Point(90, 161);
            this.button_NewQuestion.Name = "button_NewQuestion";
            this.button_NewQuestion.Size = new System.Drawing.Size(124, 23);
            this.button_NewQuestion.TabIndex = 9;
            this.button_NewQuestion.Text = "New Question";
            this.button_NewQuestion.UseVisualStyleBackColor = true;
            this.button_NewQuestion.Click += new System.EventHandler(this.button_NewQuestion_Click);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(235, 161);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(130, 23);
            this.button_check.TabIndex = 10;
            this.button_check.Text = "Check Answer";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 495);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_NewQuestion);
            this.Controls.Add(this.label_Question);
            this.Controls.Add(this.radioButton_D);
            this.Controls.Add(this.radioButton_C);
            this.Controls.Add(this.radioButton_B);
            this.Controls.Add(this.radioButton_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_A;
        private System.Windows.Forms.RadioButton radioButton_B;
        private System.Windows.Forms.RadioButton radioButton_C;
        private System.Windows.Forms.RadioButton radioButton_D;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_NewQuestion;
        private System.Windows.Forms.Button button_check;
    }
}

