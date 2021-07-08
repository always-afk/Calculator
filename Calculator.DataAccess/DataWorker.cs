using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccess
{
    public class DataWorker
    {
        public DataWorker()
        {
           
        }

        public void Save(List<string> notes)
        {
            using (AppContext db = new AppContext())
            {
                List<Note> notesList = new List<Note>();
                foreach(var e in notes)
                {
                    Note note = ConvertToNote(e);
                    notesList.Add(note);
                }
                foreach(var elem in notesList)
                {
                    if (db.Notes.Where(c => c.FirstNum == elem.FirstNum && c.SecondNum == elem.SecondNum && c.Operation == elem.Operation && c.Result == elem.Result) is null)
                    {
                        db.Notes.Add(elem);
                    }                    
                }
                db.SaveChanges();
            }
        }

        public List<string> Load()
        {
            List<string> res = new List<string>();
            using (AppContext db = new AppContext())
            {
                foreach(var e in db.Notes)
                {
                    res.Add($"{e.FirstNum} {e.Operation} {e.SecondNum} = {e.Result}");
                }
            }
            return res;
        }

        private Note ConvertToNote(string note)
        {
            string[] elems = note.Split(new char[] { ' ' });
            return new Note { FirstNum = Convert.ToDouble(elems[0]), Operation = elems[1], SecondNum = Convert.ToDouble(elems[2]), Result = Convert.ToDouble(elems[4]) };
        }
    }
}
