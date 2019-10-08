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
		public Objective(int c, int g)
		{
			Current = c;
			Goal = g;
		}
		public override int getTotalScore(int Minute)
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