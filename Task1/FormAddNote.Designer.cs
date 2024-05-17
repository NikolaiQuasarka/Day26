namespace Task1
{
    partial class FormAddNote
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
            textBoxTime = new TextBox();
            textBoxFullName = new TextBox();
            textBoxSubject = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(197, 61);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(156, 27);
            textBoxTime.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(197, 112);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(156, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(197, 159);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(156, 27);
            textBoxSubject.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(138, 216);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 5;
            label1.Text = "Дата консультации";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 6;
            label2.Text = "Время консультации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 115);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "ФИО студента";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 162);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 8;
            label4.Text = "Предмет консультации";
            // 
            // FormAddNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 257);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxFullName);
            Controls.Add(textBoxTime);
            Name = "FormAddNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление записи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTime;
        private TextBox textBoxFullName;
        private TextBox textBoxSubject;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}