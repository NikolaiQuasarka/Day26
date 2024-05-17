using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.DModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class FormAddNote : Form
    {
        public FormAddNote()
        {
            InitializeComponent();
        }
        NoteRepository noteRepository;
        public int Id;
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxFullName.Text))
                if (TimeOnly.TryParse(textBoxTime.Text, out TimeOnly time))
                {
                    noteRepository = new NoteRepository("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День26\\Day26\\Task1\\bin\\Debug\\net8.0-windows\\Consultations.mdf\";Integrated Security=True;Connect Timeout=30");
                   
                    DateTime date = dateTimePicker1.Value; date = date.Date + time.ToTimeSpan();
                    Note newNote = new Note() { StudentFullName=textBoxFullName.Text,ConstSubject=textBoxSubject.Text,ConsultationTime=date};
                    Id=noteRepository.Create(newNote);
                    Close();
                }
        }
    }
}
