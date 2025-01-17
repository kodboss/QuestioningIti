﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestioningLibrary
{
    public class ListAnswersBlock
    {
        public List<AnswersBlock> listAB = new List<AnswersBlock>();
    }

    public class ListAnswers
    {
        public List<Answer> listAnswers = new List<Answer>();
    }

    public class AnswersBlock
    {
        public string nameCompany;
        public ListQuestionBlocks LQB = new ListQuestionBlocks();
    }

    public class Answer
    {
        public int Id { get; set; }
        public int idBusinesses { get; set; }
        public int idQuestions { get; set; }
        public int idVariantsOfAnswers { get; set; }
        public string NameBusinesses { get; set; }
    }
}
