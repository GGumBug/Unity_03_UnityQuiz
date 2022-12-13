using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScene : MonoBehaviour
{
    private void Start() {
        QuizManager.GetInstance();
        LoadQuizType();
    }

    public void LoadQuizType()
    {
        int quizType = MainManager.GetInstance().quizNumber;
        UIManager.GetInstance().SetEventSystem();
        UIManager.GetInstance().OpenUI(MainManager.typeList[quizType].prepabName);
    }
}
