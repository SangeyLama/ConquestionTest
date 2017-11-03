using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace WCFConquestionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ConquestionService : IConquestionService
    {
        public ConquestionDBContext db = new ConquestionDBContext();

        public void CreateQuestionSet(QuestionSet questionSet)
        {
            db.QuestionSets.Add(questionSet);
            //foreach (Question q in questionSet.Questions)
            //{
            //    db.Questions.Add(q);
            //    foreach (Answer a in q.Answers)
            //    {
            //        db.Answers.Add(a);
            //    }
            //}
            db.SaveChanges();
        }
    }
}
