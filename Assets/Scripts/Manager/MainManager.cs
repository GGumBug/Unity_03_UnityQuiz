using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    #region SingleTone
    public static MainManager Instance;

    public static MainManager GetInstance()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("@MainManager");
            Instance = go.AddComponent<MainManager>();

            DontDestroyOnLoad(go);
        }

        return Instance;
    }
    #endregion

    public int quizNumber;
    public static QuizType[] typeList =
    {
        new QuizType("수도 퀴즈", "UICapital"),
        new QuizType("스피드 인물퀴즈", "UISpeedQuiz")
    };

    
    
}
