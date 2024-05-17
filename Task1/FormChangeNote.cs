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

namespace Task1
{
    public partial class FormChangeNote : Form
    {
        public FormChangeNote(Note note)
        {
            InitializeComponent();

            Id=note.IdNote;
            dateTimePicker1.Value = note.ConsultationTime;
            textBoxTime.Text = note.ConsultationTime.TimeOfDay.ToString();
            textBoxFullName.Text = note.StudentFullName;
            textBoxSubject.Text = note.ConstSubject;
        }
        int Id;
        NoteRepository notesRepository;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFullName.Text))
                if (TimeOnly.TryParse(textBoxTime.Text, out TimeOnly time))
                {
                    notesRepository = new NoteRepository("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День26\\Day26\\Task1\\bin\\Debug\\net8.0-windows\\Consultations.mdf\";Integrated Security=True;Connect Timeout=30");

                    DateTime date = dateTimePicker1.Value; date = date.Date + time.ToTimeSpan();
                    Note newNote = new Note() {IdNote=Id, StudentFullName = textBoxFullName.Text, ConstSubject = textBoxSubject.Text, ConsultationTime = date };
                   notesRepository.Update(newNote);
                    Close();
                }
        }
    }
}
