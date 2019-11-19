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
        protected Dictionary<string, int> Score;
        protected int Status;
        protected DateTime lastupdate;
        public int status { get => Status; }
        public string id { get => ID; }
        public string name { get => Name; }
        public Dictionary<string, int> score { get => Score; }
        public DateTime lastUpDate { get => lastupdate; }
        public enum statuses { Ongoing = 1, Done = 0, Dropped = -1, Waiting=2, Missed=-2 }
        public enum types {Objective = 1,Daily=2, Project=4,Event = 3 }
        public ThingsToDo()
        {

        }
		public ThingsToDo(string id, string name, Dictionary<string,int> score,DateTime lastup) // Constructor : hàm khởi tạo giá trị mặc định có tham số
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
		virtual public Dictionary<string,int> getTotalScore(int Minute)
		{
            Dictionary<string, int> Scores = new Dictionary<string, int>(this.Score);
            
            foreach(var x in Scores)
            {
                Scores[x.Key] *= Minute; 
            }

			return Scores;
		}
		virtual public void updateStatus()
		{

		}
        virtual public int getTTDType()
        {
            throw new InvalidOperationException();
        }
	}
}