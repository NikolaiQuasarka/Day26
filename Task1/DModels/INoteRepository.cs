using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DModels
{
    public interface INoteRepository
    {
        int Create(Note note);
        void Delete(int id);
        Note Get(int id); 
        List<Note> GetNotes();
        void Update(Note note);
    }

    public class NoteRepository : INoteRepository
    {
        string ConnectionString = null;
        public NoteRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<Note> GetNotes()
        {
            using(IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Note>("SELECT * FROM Note").ToList();
            }
        }

        public Note Get(int id)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Note>("SELECT * FROM Note WHERE IdNote=@id", new {id}).FirstOrDefault();

            }
        }

        public int Create(Note note)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                //var sqlQuery = "INSERT INTO Note (StudentFullName,ConstSubject,ConsultationTime) VALUES(@Name, @Subj,@Time)";
                //db.Execute(sqlQuery, note);

   
               var sqlQuery = "INSERT INTO Note (StudentFullName, ConstSubject,ConsultationTime) VALUES(@StudentFullName, @ConstSubject,@ConsultationTime); SELECT CAST(SCOPE_IDENTITY() as int)";
                int noteId = db.Query<int>(sqlQuery, note).FirstOrDefault();
                return noteId;
            }
        }

        public void Update(Note note)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var sqlQuery = "UPDATE Note SET StudentFullName = @StudentFullName, ConstSubject=@ConstSubject, ConsultationTime=@ConsultationTime WHERE IdNote = @IdNote";
                db.Execute(sqlQuery, note);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var sqlQuery = "DELETE FROM Note WHERE IdNote = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
