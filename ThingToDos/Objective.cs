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
		int Goal;
		public Objective(string id,string name, List<int> score,DateTime lastup, int g):base(id,name,score, lastup)
		{
			Current = 0;
			Goal = g;
		}
		public override List<int> getTotalScore(int Minute)
		{

			return base.getTotalScore(Minute);
		}
		public override void updateStatus()
		{
			if (lastupdate /*chỗ này cộng 1 khoảng thời gian*/ < DateTime.Now)
			{
				Status = -1;
				return;
			}
			if (Current > Goal)
			{
				Status = 0;
				return;
			}
		}
	}
}