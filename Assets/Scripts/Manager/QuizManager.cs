using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    #region SingleTone
    public static QuizManager Instance;

    public static QuizManager GetInstance()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("@QuizManager");
            Instance = go.AddComponent<QuizManager>();

            DontDestroyOnLoad(go);
        }

        return Instance;
    }
    #endregion

    [SerializeField]
    public int curQuizNumber = 0;
    public static CapitalQuiz[] capitalQuizList = 
    {
        new CapitalQuiz(0, "Sweden", 1, new List<string> {"함마르비", "스톡홀름", "코펜하겐", "헬싱키"}),
        new CapitalQuiz(1, "Malaysia", 0, new List<string> {"쿠알라룸푸르", "마닐라", "코타키나발루", "자카르타"}),
        new CapitalQuiz(1, "Germany", 2, new List<string> {"뮌헨", "프랑크프루트", "베를린", "잘츠부르크"})

    };
}
