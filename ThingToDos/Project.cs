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
        public Project(string id,string name, List<int> score, DateTime lastup, DateTime Deadline) : base(id, name, score, lastup)
        {
            this.Deadline = Deadline;
        }
		public override List<int> getTotalScore(int Minute)
		{
            return base.getTotalScore(Minute);
		}
        public override void InsertToDatabase()
        {
            int type = 4;
            List<string> columns = new List<string>() { "ID", "Name", "Status", "lastupdate", "TxtRow1", "Type" };
            List<string> values = new List<string>() { ID, Name, Status.ToString(), lastupdate.ToString("yyyy'-'MM'-'dd HH:mm:ss"), Deadline.ToString("yyyy'-'MM'-'dd HH:mm:ss"), type.ToString() };
            Program.manager.InsertTo("ThingToDo", columns, values);
            base.InsertToDatabase();
        }
    }
}