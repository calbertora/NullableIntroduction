namespace NullableIntroduction.Models
{
    public enum QuestionType
    {
        YesNo,
        Number,
        Text
    }
    public class SurveyQuestion
    {
        public string QuestionText { get; set; }
        public QuestionType TypeOfQuestion { get; set; }

        public SurveyQuestion(QuestionType typeOfQuestion, string text) 
            => (QuestionText,TypeOfQuestion) = (text,typeOfQuestion);
    
    }    
}