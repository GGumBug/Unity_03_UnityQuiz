using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapitalQuiz
{
    public int quizNumber;
    public string flagName;
    public int quizAnswer;
    public List<string> exampleList;

    public CapitalQuiz(int quizNumber, string flagName,int quizAnswer, List<string> exampleList)
    {
        this.quizNumber = quizNumber;
        this.flagName = flagName;
        this.quizAnswer = quizAnswer;
        this.exampleList = exampleList;
    }
}
