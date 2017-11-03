
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConquestionWebClientTest.RemoteWCFConquestionService;


namespace ConquestionWebClientTest.Controllers
{
    public class QuestionSetController : Controller
    {
        ConquestionServiceClient client = new ConquestionServiceClient();
        // GET: QuestionSet
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Question(QuestionSet questionSet)
        {
            client.CreateQuestionSet(questionSet);
            return View(questionSet);
        }
        public ActionResult Question()
        {
            return View();
        }
    }
}