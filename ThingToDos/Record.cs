using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
    class Record
    {
        long _TTD_ID;
        long _Current;
        DateTime _Date;
        public Record()
        {

        }
        public Record(int TTD_ID,DateTime Date,int Current)
        {
            this.TTD_ID = TTD_ID;
            this.Current = Current;
            this._Date = Date;
        }

        public long TTD_ID { get => _TTD_ID; set => _TTD_ID = value; }
        public long Current { get => _Current; set => _Current = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
    }
}
