using System;
using System.Collections.Generic;

namespace Do_An
{
    public class ThingsToDo
    {
        protected string ID;
        protected string Name;
        protected Dictionary<long, int> Score;
        protected int Status;
        protected DateTime lastupdate;
        public int status { get => Status; }
        public string id { get => ID; set => ID = value; }
        public string name { get => Name; }
        public Dictionary<long, int> score { get => Score; }
        public DateTime lastUpDate { get => lastupdate; }
        public enum statuses { Ongoing = 1, Done = 0, Dropped = -1, Waiting = 2, Missed = -2 }
        public enum types { Objective = 1, Daily = 2, Project = 4, Event = 3 }
        public ThingsToDo()
        {

        }
        public ThingsToDo(string name, Dictionary<long, int> score, DateTime lastup) // Constructor : hàm khởi tạo giá trị mặc định có tham số
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
        virtual public Dictionary<long, int> getTotalScore(int Minute)
        {
            Dictionary<long, int> Scores = new Dictionary<long, int>(this.Score);

            foreach (var x in Scores)
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
        virtual public void UpdateAfterDoingSomethings()
        {

        }
    }
}