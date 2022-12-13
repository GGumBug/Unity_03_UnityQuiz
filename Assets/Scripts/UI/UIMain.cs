using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    Transform typeButtonList;
    public UIMainButton quizType;
    string curType;

    private void Start() {

        typeButtonList = GameObject.FindGameObjectWithTag("TypeBtnList").transform;
        LoadQuizType();
    }

    public void LoadQuizType()
    {
        for (int i = 0; i < MainManager.typeList.Length; i++)
        {
            Object obj = Resources.Load("UI/mainButton");
            GameObject go = (GameObject)Instantiate(obj, typeButtonList);
            quizType = go.GetComponent<UIMainButton>();
            quizType.SetReference();
            int a = i;
            quizType.btnQuizType.onClick.AddListener(() => {OnQuizSceneStart(a);});

            quizType.txtQuizType.text = MainManager.typeList[i].type;
        }

    }

    public void OnQuizSceneStart(int num)
    {
        MainManager.GetInstance().quizNumber = num;
        ScenesManager.GetInstance().ChangeScene(Scene.Quiz);
    }
}
