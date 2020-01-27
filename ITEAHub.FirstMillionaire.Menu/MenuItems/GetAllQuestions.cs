using ITEAHub.FirstMillionaire.Contractor.Interfaces;
using ITEAHub.FirstMillionaire.DataObjects.Models;
using ITEAHub.Millionaire.DataSourse;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITEAHub.FirstMillionaire.Menu.MenuItems
{
    public class GetAllQuestions : IMenu
    {
        private IDataSourseQuestion _dataSourseQuestion;

        public string Name
        {
            get => "Show all questions";
        }

        public GetAllQuestions()
        {
            _dataSourseQuestion = new FileReader();
        }

        public void Action()
        {
            Show();
        }

        private void Show()
        {
            Console.WriteLine("=== All questions == ");
            foreach (var item in _dataSourseQuestion.GetAll())
            {
                Console.WriteLine($"{item.Body}");

                foreach (var answer in item.Answers)
                {
                    if(answer == item.Correct)
                    {
                        Console.WriteLine($"\t + {answer.Body}");
                    }
                    else
                    {
                        Console.WriteLine($"\t {answer.Body}");
                    }
                }
            }
        }

    }
}
