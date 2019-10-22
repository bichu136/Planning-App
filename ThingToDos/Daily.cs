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
			if (lastupdate /*chỗ này cộng 1 khoảng thời gian*/< DateTime.Now)
			{
				Status = -1;
				return;
			}
		}
	}
}