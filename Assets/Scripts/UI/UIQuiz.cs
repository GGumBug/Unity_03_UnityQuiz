using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIQuiz : MonoBehaviour
{
    Transform exampleList;
    Image imgFlag;
    UIBtnExample[] uIBtnExample;

    private void Start() {
        imgFlag = GetComponentInChildren<Image>();
        exampleList = GameObject.FindGameObjectWithTag("ExampleList").transform;
        CreateBTNs();
        LoadBTNExample();
    }

    public void CreateBTNs()
    {
        uIBtnExample = new UIBtnExample[4];
        for (int i = 0; i < 4; i++)
        {
            Object obj = Resources.Load("UI/btnExample");
            GameObject go = (GameObject)Instantiate(obj, exampleList);
            UIBtnExample btn = go.GetComponent<UIBtnExample>();
            uIBtnExample[i] = btn;
        }
    }

    public void LoadBTNExample()
    {
        int curQuizNumber = QuizManager.GetInstance().curQuizNumber;
        int a = QuizManager.capitalQuizList[curQuizNumber].exampleList.Count;
        imgFlag.sprite = Resources.Load<Sprite>($"Flag/{QuizManager.capitalQuizList[curQuizNumber].flagName}");
        for (int i = 0; i < a; i++)
        {
            uIBtnExample[i].SetBTNExample(QuizManager.GetInstance().curQuizNumber ,i);
        }

    }

}