using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    public Button btnStart;
    private void Start() {
        btnStart = GetComponentInChildren<Button>();
        btnStart.onClick.AddListener(MainSceneStart);
    }

    public void MainSceneStart()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Main);
    }
}
