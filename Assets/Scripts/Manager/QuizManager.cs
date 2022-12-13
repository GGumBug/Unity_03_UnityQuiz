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
    public int matchingQuiz = 0;
    public static CapitalQuiz[] capitalQuizList = 
    {
        new CapitalQuiz(0, "Sweden", 1, new List<string> {"함마르비", "스톡홀름", "코펜하겐", "헬싱키"}),
        new CapitalQuiz(1, "Malaysia", 0, new List<string> {"쿠알라룸푸르", "마닐라", "코타키나발루", "자카르타"}),
        new CapitalQuiz(2, "Germany", 2, new List<string> {"뮌헨", "프랑크프루트", "베를린", "잘츠부르크"}),
        new CapitalQuiz(3, "China", 2, new List<string> {"상하이", "타이베이", "베이징", "칭타오"}),
        new CapitalQuiz(4, "Ghana", 3, new List<string> {"쿠마시", "타말", "로메", "아크라"}),
        new CapitalQuiz(5, "French", 0, new List<string> {"파리", "니스", "리몽", "브뤼셀"}),
        new CapitalQuiz(6, "Spain", 1, new List<string> {"바르셀로나", "마드리드", "그라나다", "리스본"}),
        new CapitalQuiz(7, "Hungary", 3, new List<string> {"부쿠레슈티", "자그레브", "리스본", "부다페스트"}),
        new CapitalQuiz(8, "Luxembourg", 2, new List<string> {"릴", "크노케", "룩셈부르크", "퀼른"}),
        new CapitalQuiz(9, "Bulgaria", 1, new List<string> {"베오그라드", "소피아", "부큐레슈티", "바르나"}),


    };

    public void ResetQuiz()
    {
        curQuizNumber = 0;
        matchingQuiz = 0;
    }
}
