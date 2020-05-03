using JAQ_BackendDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAQ_BackendDev.Web.ViewModels
{
    public class QuizScore
    {

        public Scores score { get; set; }

        public Quiz quiz { get; set; }
    }
}
