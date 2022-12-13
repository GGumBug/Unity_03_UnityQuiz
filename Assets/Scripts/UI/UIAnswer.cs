using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIAnswer : MonoBehaviour
{
    public Image imgflag;
    public TMP_Text txtInfo;
    public Button btnNext;

    private void Start() {
        btnNext.onClick.AddListener(NextQuiz);
    }

    public void AnswerReference(string flagName, string countryName, string capitalName)
    {
        imgflag.sprite = Resources.Load<Sprite>($"Flag/{flagName}");
        txtInfo.text = $"{countryName}의 수도는 {capitalName}입니다.";
    }

    public void NextQuiz()
    {
        int quizType = MainManager.GetInstance().quizNumber;

        UIManager.GetInstance().CloseUI("UIAnswer");
        UIManager.GetInstance().OpenUI(MainManager.typeList[quizType].prepabName);
        UIQuiz uIQuiz = UIManager.GetInstance().GetUI(MainManager.typeList[quizType].prepabName).GetComponent<UIQuiz>();
        uIQuiz.LoadBTNExample();
    } 
}
