using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
    class Objective : ThingsToDo
    {
        int Current;
        public int current { get => Current; }
		int Goal;
        public int goal { get =>Goal; }
		public Objective(string id,string name, Dictionary<string,int> score,DateTime lastup, int g,int c = 0):base(id,name,score, lastup)
		{
			Current = c;
			Goal = g;
		}
		public override Dictionary<string,int> getTotalScore(int Minute)
		{

			return base.getTotalScore(Minute);
		}
		public override void updateStatus()
		{
			if (lastupdate.AddMonths(1) < DateTime.Now)
			{
				Status = (int)statuses.Dropped;
				return;
			}
			if (Current > Goal)
			{
				Status = (int)statuses.Done;
				return;
			}
		}
        //public override void InsertToDatabase()
        //{
        //    int type = 0;
        //    List<string> columns = new List<string>() { "ID", "Name", "Status", "lastupdate", "IntRow1","Int", "Type" };
        //    List<string> values = new List<string>() { ID, Name, Status.ToString(), lastupdate.ToString("yyyy'-'MM'-'dd HH:mm:ss"), Current.ToString(),Goal.ToString(), type.ToString() };
        //    Program.manager.InsertTo("ThingToDo", columns, values);
        //    base.InsertToDatabase();
        //}

    }
}