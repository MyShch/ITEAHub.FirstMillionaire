using ITEAHub.FirstMillionaire.Contractor.Interfaces;
using ITEAHub.FirstMillionaire.DataObjects.Enums;
using ITEAHub.FirstMillionaire.DataObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITEAHub.Millionaire.DataSourse
{
    public class FileReader : IDataSourseQuestion
    {
        private List<Question> _questions;

        public FileReader()
        {
            _questions = new List<Question>();

            var question1 = new Question
            {
                Body = "2 + 3 = ",
                Level = Level.Low,
            };
            var answ1 = new Answer
            {
                Body = "6"
            };
            var answ2 = new Answer
            {
                Body = "5"
            };
            var answ3 = new Answer
            {
                Body = "3"
            };
            var answ4 = new Answer
            {
                Body = "2"
            };
            question1.Answers = new List<Answer>
            {
                answ1,
                answ2,
                answ3,
                answ4
            };
            question1.Correct = answ2;

            _questions.Add(question1);
        }

        public void Add(Question question)
        {
            _questions.Add(question);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Question question)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll()
        {
            return _questions;
        }

        public Question GetById(string id)
        {
            return _questions.FirstOrDefault(x => x.Id == id);
        }
    }
}
