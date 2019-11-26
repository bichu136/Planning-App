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
        public enum Unit {Minutes = 1,Times = -1 }
        public String unit;
		public Objective(string name, Dictionary<long,int> score,DateTime lastup, int g,String unit):base(name,score, lastup)
        {
			Goal = g;
            this.unit = unit;
		}
		public override Dictionary<long,int> getTotalScore(int Minute)
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