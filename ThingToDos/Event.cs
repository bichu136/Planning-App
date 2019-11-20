using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
	class Event : ThingsToDo
	{
		DateTime BeginTime;
        public DateTime beginTime { get => BeginTime; }
        public Event(string name, Dictionary<long,int> score,DateTime lastup,DateTime beginTime) : base( name, score, lastup)
        {
            BeginTime = beginTime;
        }
		public override Dictionary<long,int> getTotalScore(int Minute)
		{
			return base.getTotalScore(Minute);
		}
		public void UpdateStatus(bool flag = false)
		{
			if (DateTime.Now < BeginTime)
			{
				Status = (flag) ? 1 : 2;
				return;
			}
			else
			{
				if (Status == 1)
				{
					Status = 0;
				}
				else Status = -2;
			}
		}
        
    }
}