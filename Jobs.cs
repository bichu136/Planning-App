using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
    class Jobs
    {
        public enum Status {Ongoing=1,Dropped=-1,Waiting=2,Complete=0 };
        public enum Stats { Works = 1, Relax = 0, Sports=2};
        protected String ID;
        protected String name;
        protected int status;
        protected int stats;
        protected int Score;
        protected DateTime lastupdate;
        void setScoreAndStats(int stats)
        {
            this.stats = stats % 10;
        }
        void UpdateDrop() {

        }
    }
}
