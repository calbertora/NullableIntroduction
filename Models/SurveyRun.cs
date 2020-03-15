using System;
using System.Collections.Generic;

namespace NullableIntroduction.Models
{
    public class SurveyRun
    {
        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();

        public void AddQuestion(QuestionType type, string text)
            => AddQuestion(new SurveyQuestion(type,text));

        public void AddQuestion(SurveyQuestion surveyQuestion)
            => surveyQuestions.Add(surveyQuestion);
    }    
}