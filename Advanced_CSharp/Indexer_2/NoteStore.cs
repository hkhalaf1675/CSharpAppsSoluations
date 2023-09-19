using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_2
{
    internal class NoteStore
    {
        Note[] notes;
        int size;

        public NoteStore(int _size)
        {
            notes = new Note[_size];
            size = _size;
        }

        public Note this[int index]
        {
            get { return notes[index]; }
            set { notes[index] = value; }
        }
    }
}
