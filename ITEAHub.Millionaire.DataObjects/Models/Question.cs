using ITEAHub.FirstMillionaire.DataObjects.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITEAHub.FirstMillionaire.DataObjects.Models
{
    public class Question
    {
        public string Id { get; set; }

        public List<Answer> Answers { get; set; }

        public Answer Correct { get; set; }

        public string Body { get; set; }

        public Level Level { get; set; }
    }
}
