﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
	class Project : ThingsToDo
	{
		DateTime Deadline;
        public DateTime deadline { get => Deadline; }
        public Project(string id,string name, Dictionary<string,int> score, DateTime lastup, DateTime Deadline) : base(id, name, score, lastup)
        {
            this.Deadline = Deadline;
        }
		public override Dictionary<string,int> getTotalScore(int Minute)
		{
            return base.getTotalScore(Minute);
		}
        //public override void InsertToDatabase()
        //{
        //    int type = 4;
        
        //    Program.manager.InsertTo("ThingToDo", columns, values);
        //    base.InsertToDatabase();
        //}
    }
}