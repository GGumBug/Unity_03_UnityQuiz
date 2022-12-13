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
        if (answer == QuizManager.capitalQuizList[curQuizNumber].quizAnswer)
        {
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

    }


}
