using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
	class Daily : ThingsToDo
	{
		private int factor;
        public int Factor { get => factor; }
        public Daily(string id, string name, Dictionary<string,int> score, DateTime lastup,int factor): base(id, name,score, lastup)
        {
            this.factor = factor;
        }
        public override Dictionary<string,int> getTotalScore(int Minute)
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
        public bool IsDone()
        {
            return true;
        }
    }
}