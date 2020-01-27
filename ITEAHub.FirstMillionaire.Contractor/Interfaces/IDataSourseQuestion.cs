using ITEAHub.FirstMillionaire.DataObjects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITEAHub.FirstMillionaire.Contractor.Interfaces
{
    public interface IDataSourseQuestion
    {
        void Add(Question question);

        void Edit(Question question);

        List<Question> GetAll();

        Question GetById(string id);

        void Delete(string id);
    }
}
