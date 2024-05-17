namespace Task1
{
    partial class FormChangeNote
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
            dateTimePicker1 = new DateTimePicker();
            textBoxTime = new TextBox();
            textBoxFullName = new TextBox();
            textBoxSubject = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(209, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(209, 112);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(164, 27);
            textBoxTime.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(209, 170);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(164, 27);
            textBoxFullName.TabIndex = 2;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(209, 233);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(164, 27);
            textBoxSubject.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(140, 295);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 57);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 5;
            label1.Text = "Дата консультации";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 6;
            label2.Text = "Время консультации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 173);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "ФИО студента";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 236);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 8;
            label4.Text = "Предмет консультации";
            // 
            // FormChangeNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 336);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxFullName);
            Controls.Add(textBoxTime);
            Controls.Add(dateTimePicker1);
            Name = "FormChangeNote";
            Text = "Изменение записи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBoxTime;
        private TextBox textBoxFullName;
        private TextBox textBoxSubject;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}