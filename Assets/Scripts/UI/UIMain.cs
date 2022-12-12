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
            quizType.btnQuizType.onClick.AddListener(OnQuizSceneStart);

            quizType.txtQuizType.text = MainManager.typeList[i].type;
        }

    }

    public void OnQuizSceneStart()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Quiz);
    }
}
