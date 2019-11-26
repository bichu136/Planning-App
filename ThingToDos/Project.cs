using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
	class Project : ThingsToDo
	{
		DateTime Deadline;
        public DateTime deadline { get => Deadline; }
        public int HasPlan;
        public Project(string name, Dictionary<long,int> score, DateTime lastup, DateTime Deadline,bool Checked) : base( name, score, lastup)
        {
            this.Deadline = Deadline;
            this.HasPlan = (Checked) ? 1 : 0;
        }
		public override Dictionary<long,int> getTotalScore(int Minute)
		{
            return base.getTotalScore(Minute);
		}
        //public override void InsertToDatabase()
        //{
        //    int type = 4;
        
        //    Program.manager.InsertTo("ThingToDo", columns, values);
        //    base.InsertToDatabase();
        //}
    }
}