 class Riddle
{
    string  riddle;
    string [] answers;
    int correctAnswerIndex;

    public Riddle (string Riddle, string[] answers, int correctAnswerIndex){
        this.riddle = riddle;
        this.answers = new string [answers.Length];
        answers.CopyTo(this.answers, 0);
        this.correctAnswerIndex = correctAnswerIndex;
    }
}