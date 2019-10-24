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
        public static double Map(this double value, double fromSource, double toSource, double fromDestination, double toDestination)
        {
            return (value - fromSource) / (toSource - fromSource) * (toDestination - fromDestination) + fromDestination;
        }
        public override int getTotalScore(int Minute)
		{
            TimeSpan Temp = Deadline.Subtract (lastupdate);
            double a = 0;
            if ( Temp.Days > 60 ) { a = 1.5; }
            else if (Temp.Days <3) { a = 0; }
            else {
                    double b = (Convert.ToDouble(Temp.Days));
                    a = b.Map(3, 60, 0.25, 1.5);
            }
            return Convert.ToInt32(a*(Convert.ToDouble(base.getTotalScore(Minute))));
		}
        public override void updateStatus()
        {
            
        }
    }
}