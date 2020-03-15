using System;
using System.Collections.Generic;
using System.Linq;

namespace NullableIntroduction.Models
{
    public class SurveyRun
    {
        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();
        private List<SurveyResponse>? respondents;
        public IEnumerable<SurveyResponse> AllParticipants => (respondents ?? Enumerable.Empty<SurveyResponse>());
        public ICollection<SurveyQuestion> Questions => surveyQuestions;
        public SurveyQuestion GetQuestion(int index) => surveyQuestions[index];

        public void AddQuestion(QuestionType type, string text)
            => AddQuestion(new SurveyQuestion(type,text));

        public void AddQuestion(SurveyQuestion surveyQuestion)
            => surveyQuestions.Add(surveyQuestion);

        public void PerformSurvey(int numberOfRespondents)
        {
            int repondentsConsenting = 0;
            respondents = new List<SurveyResponse>();
            while (repondentsConsenting < numberOfRespondents)
            {
                var respondent = SurveyResponse.GetRandomId();
                if (respondent.AnswerSurvey(surveyQuestions))
                    repondentsConsenting++;
                respondents.Add(respondent);
            }
        }

    }    
}