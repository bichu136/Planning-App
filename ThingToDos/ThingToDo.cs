using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
	class ThingsToDo
	{
		protected string ID;
		protected string Name;
		protected List<int> Score;
		protected int Status;
		protected DateTime lastupdate;
        public enum statuses { Ongoing = 1, Done = 0, Dropped = -1, Waiting=2, Missed=-2 }
        public ThingsToDo()
        {

        }
		public ThingsToDo(string id, string name, List<int> score,DateTime lastup) // Constructor : hàm khởi tạo giá trị mặc định có tham số
        {
            ID = id;
            Name = name;
            Score = score;
            Status = 1;
            lastupdate = lastup;
        }
		public void update() // phương thức update
		{
			lastupdate = DateTime.Now; // cập nhật lastupdate = thời gian hiện tại
		}
		virtual public List<int> getTotalScore(int Minute)
		{
            List<int> Scores = this.Score;
            for (int i = 0; i < Scores.Count; i++)
            {
                Scores[i] *= Minute;
            }

			return Scores;
		}
        public virtual void InsertToDatabase()
        {
            //add TTD_Stats thoi tai cai do chung dc.
            for(int i = 0; i < Score.Count; i++)
            {
                if (Score[i] != 0)
                {
                    Program.manager.InsertTo("TTD_Stats", new List<string> { ID, i.ToString(), Score[i].ToString() });
                }
            }
        }
		virtual public void updateStatus()
		{

		}
	}
}