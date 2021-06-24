﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBWorker;

namespace CalculatorLibrary
{
    public class DataWorker
    {
        public List<Note> Notes { get; set; }

        public DataWorker() 
        {
            Notes = new List<Note>();
        }

        public bool SaveHistory()
        {
            if (Notes is null)
            {
                return false;
            }

            using (NoteContext db = new NoteContext())
            {
                db.Notes.AddRange(Notes);
                return true;
            }            
        }

        public bool LoadHistory()
        {
            using (NoteContext db = new NoteContext())
            {
                foreach (Note note in db.Notes)
                {
                    Notes.Add(note);
                }
            }
            return true;
        }
    }
}
