using Task1.DModels;

namespace Task1
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
            noteRepository = new NoteRepository("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День26\\Day26\\Task1\\bin\\Debug\\net8.0-windows\\Consultations.mdf\";Integrated Security=True;Connect Timeout=30");
            foreach (Note note in noteRepository.GetNotes())
            {
                dataGridView1.Rows.Add(note.IdNote, note.ConsultationTime, note.StudentFullName, note.ConstSubject);
            }
        }
        NoteRepository noteRepository;

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddNote formAddNote = new FormAddNote();
            formAddNote.FormClosed += delegate (object? sender, FormClosedEventArgs e)
            {
                Note note = noteRepository.Get(formAddNote.Id);
                dataGridView1.Rows.Add(note.IdNote,note.ConsultationTime,note.StudentFullName,note.ConstSubject);
            };
            formAddNote.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                noteRepository.Delete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                FormChangeNote formChangeNote = new FormChangeNote(noteRepository.Get(id));
                formChangeNote.FormClosed += delegate (object? sender, FormClosedEventArgs e)
                {
                    Note note = noteRepository.Get(id);
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    row.Cells[1].Value=note.ConsultationTime;
                    row.Cells[2].Value=note.StudentFullName;
                    row.Cells[3].Value=note.ConstSubject;
                };
                formChangeNote.ShowDialog();
            }
        }
    }
}
