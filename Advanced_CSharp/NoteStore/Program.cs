using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notesStoreObj = new NotesStore();
            notesStoreObj.AddNote("active", "active");
            notesStoreObj.AddNote("active", "active");
            notesStoreObj.AddNote("active", "active");

            notesStoreObj.Show();

            //var n = int.Parse(Console.ReadLine());
            //for (var i = 0; i < n; i++)
            //{
            //    var operationInfo = Console.ReadLine().Split(' ');
            //    try
            //    {
            //        if (operationInfo[0] == "AddNote")
            //            notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
            //        else if (operationInfo[0] == "GetNotes")
            //        {
            //            var result = notesStoreObj.GetNotes(operationInfo[1]);
            //            if (result.Count == 0)
            //                Console.WriteLine("No Notes");
            //            else
            //                Console.WriteLine(string.Join(",", result));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Parameter");
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Error: " + e.Message);
            //    }
            //}
        }
    }

    class Note
    {
        public string name;
        public string state;

        public Note(string _name, string _state)
        {
            name = _name;
            state = _state;
        }
    }
    class NotesStore
    {
        Note[] notes;
        int index;

        public NotesStore()
        {
            notes = new Note[10];
            index = 0;
        }
        public void AddNote(string state, string name)
        {
            if (name == "")
            {
                throw new Exception("Name cannot be empyt");
            }
            if (state != "completed" && state != "active" && state != "others")
            {
                throw new Exception($"Invalid state {state}");
            }
            notes[index++] = new Note(name, state);
        }


        public List<String> GetNotes(String state)
        {

            List<string> list = new List<string>();

            if (state != "completed" && state != "active" && state != "others")
            {
                throw new Exception($"Invalid state {state}");
            }
            foreach (Note note in notes)
            {
                if (note.state.Equals(state))
                    list.Add(note.name);
            }
            return list;
        }

        public void Show()
        {
            foreach (Note note in notes)
                Console.WriteLine($"Name : {note.name} , State : {note.state}");
        }
    }
}
