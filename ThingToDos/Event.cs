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
		public override List<int> getTotalScore(int Minute)
		{
			return base.getTotalScore(Minute);
		}
		public void UpdateStatus(bool flag = false)
		{
			if (DateTime.Now < /*một khoảng thời gian +*/BeginTime)
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