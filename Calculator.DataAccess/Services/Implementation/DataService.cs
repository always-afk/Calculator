using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccess
{
    public class DataService : IDataService
    {
        private readonly AppContext _context;

        public DataService(AppContext appContext)
        {
            _context = appContext;
        }

        public void Save(List<string> notes)
        {            
            List<Note> notesList = new List<Note>();
            foreach(var e in notes)
            {
                Note note = ConvertToNote(e);
                notesList.Add(note);
            }
            foreach(var elem in notesList)
            {
                if (!_context.Notes.Any(c => c.FirstNum == elem.FirstNum && c.SecondNum == elem.SecondNum && c.Operation == elem.Operation))
                {
                    _context.Notes.Add(elem);
                }                    
            }
            _context.SaveChanges();
            
        }

        public List<string> Load()
        {
            List<string> res = new List<string>();
            
            foreach(var e in _context.Notes)
            {
                res.Add($"{e.FirstNum} {e.Operation} {e.SecondNum} = {e.Result}");
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
