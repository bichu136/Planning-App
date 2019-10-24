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
		protected int Stat;
		protected int Score;
		protected int Status;
		protected DateTime lastupdate;
		/*public ThingsToDo(string id, string name,int stat,int score,DateTime lastup) // Constructor : hàm khởi tạo giá trị mặc định có tham số
        {
            ID = id;
            Name = name;
            Stat = stat;
            Score = score;
            Status = 1;
            lastupdate = lastup;
        }*/
		public void update() // phương thức update
		{
			lastupdate = DateTime.Now; // cập nhật lastupdate = thời gian hiện tại
		}
		virtual public int getTotalScore(int Minute)
		{
			return Minute * Score;
		}
		virtual public void updateStatus()
		{

		}

    }
}