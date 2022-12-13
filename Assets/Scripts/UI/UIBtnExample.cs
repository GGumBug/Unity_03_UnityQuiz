using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIBtnExample : MonoBehaviour
{
    Button btnExample;
    TMP_Text txtNumber;
    GameObject answerGo;

    public void SetBTNExample(int curQuizNumber, int idx)
    {
        btnExample = GetComponent<Button>();
        txtNumber = GetComponentInChildren<TMP_Text>();
        
        btnExample.onClick.AddListener(() => {OnClickChoice(idx);} );
        txtNumber.text = QuizManager.capitalQuizList[curQuizNumber].exampleList[idx];
    }

    public void OnClickChoice(int answer)
    {
        int curQuizNumber = QuizManager.GetInstance().curQuizNumber;
        
        if (QuizManager.GetInstance().matchingQuiz >= 9)
        {
            QuizManager.GetInstance().matchingQuiz++;
            Clear();
        }
        else if (answer == QuizManager.capitalQuizList[curQuizNumber].quizAnswer)
        {
            QuizManager.GetInstance().matchingQuiz++;
            Answer();
        }
        else 
        {
            Wrong();
        }
    }

    public void Answer()
    {
        int quizType = MainManager.GetInstance().quizNumber;
        int curQuizNumber = QuizManager.GetInstance().curQuizNumber;
        string flagName = QuizManager.capitalQuizList[curQuizNumber].flagName;
        string capitalName = QuizManager.capitalQuizList[curQuizNumber].exampleList[QuizManager.capitalQuizList[curQuizNumber].quizAnswer];

        UIManager.GetInstance().CloseUI(MainManager.typeList[quizType].prepabName);

        UIManager.GetInstance().OpenUI("UIAnswer");
        GameObject answerGo = UIManager.GetInstance().GetUI("UIAnswer");
        UIAnswer answer = answerGo.GetComponent<UIAnswer>();
        answer.AnswerReference(flagName, flagName, capitalName);

        QuizManager.GetInstance().curQuizNumber++;
    }

    public void Wrong()
    {
        int quizType = MainManager.GetInstance().quizNumber;
        UIManager.GetInstance().CloseUI(MainManager.typeList[quizType].prepabName);

        UIManager.GetInstance().OpenUI("UIWrong");
        UIWrong uiWrong = UIManager.GetInstance().GetUI("UIWrong").GetComponent<UIWrong>();
        uiWrong.ConnectObject();
        uiWrong.txtScore.text = $"맞춘문제 : {QuizManager.GetInstance().matchingQuiz} / 10";

        uiWrong.btnReTry.onClick.AddListener(ReTry);
    }

    public void Clear()
    {  
        int quizType = MainManager.GetInstance().quizNumber;
        UIManager.GetInstance().CloseUI(MainManager.typeList[quizType].prepabName);

        UIManager.GetInstance().OpenUI("UIClear");
        UIClear uiClear = UIManager.GetInstance().GetUI("UIClear").GetComponent<UIClear>();
        uiClear.ConnectObject();
        uiClear.btnReTry.onClick.AddListener(ReTry);

    }

    public void ReTry()
    {
        UIManager.GetInstance().CloseUI("UIWrong");
        UIManager.GetInstance().CloseUI("UIClear");
        QuizManager.GetInstance().ResetQuiz();
        ScenesManager.GetInstance().ChangeScene(Scene.Main);
    }


}
