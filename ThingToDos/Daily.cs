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
        public int WeekDayToDo { get => _WeekDayToDo; set => _WeekDayToDo = value; }
        public int Factor { get => factor; }
        public enum statuses  { Ongoing = 1, Done = 0, }
        private int _WeekDayToDo;
        public Daily(string name, Dictionary<long,int> score, DateTime lastup,int factor,int weekDayToDo): base( name,score, lastup)
        {
            this.factor = factor;
            this.WeekDayToDo = weekDayToDo;
        }
        
        public override Dictionary<long,int> getTotalScore(int Minute)
		{
            //TODO: số lần làm * factor cho mỗi giá trị điểm.
            return null;
		}
		public override void updateStatus()
		{
            base.updateStatus();
			if (lastupdate.AddMonths(1)< DateTime.Now)
			{
				Status = (int)ThingsToDo.statuses.Dropped;
				return;
			}
            if(WeekDayToDo <7)
            {
                if (WeekDayToDo == (int)DateTime.Now.DayOfWeek)
                {
                    if(lastupdate.Date == DateTime.Now)
                    {
                        return;
                    }
                    else
                    {
                        Status = (int)ThingsToDo.statuses.Ongoing;
                    }
                }
            }
		}
        public bool IsDone()
        {
            
            return true;
        }
        public override void UpdateAfterDoingSomethings()
        {
            //Status = 
        }
    }
}