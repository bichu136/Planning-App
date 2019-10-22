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
		public override List<int> getTotalScore(int Minute)
		{
			return base.getTotalScore(Minute);
		}
	}
}