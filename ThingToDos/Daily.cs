using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
	class Daily : ThingsToDo
	{
		int factor;
        public Daily(string id, string name, List<int> score, DateTime lastup,int factor): base(id, name,score, lastup)
        {
            this.factor = factor;
        }

        public int Factor { get => factor; }

        public override List<int> getTotalScore(int Minute)
		{
			return base.getTotalScore(Minute);
		}
		public override void updateStatus()
		{
            base.updateStatus();
			if (lastupdate.AddMonths(1)< DateTime.Now)
			{
				Status = -1;
				return;
			}
		}
        public override void InsertToDatabase()
        {
            int type = 1;
            List<string> columns = new List<string>() {"ID","Name","Status","lastupdate","IntRow1","Type"};
            List<string> values = new List<string>() { ID, Name, Status.ToString(), lastupdate.ToString("yyyy'-'MM'-'dd HH:mm:ss"), factor.ToString(),type.ToString() };
            Program.manager.InsertTo("ThingToDo", columns,values);
            base.InsertToDatabase();
        }
    }
}