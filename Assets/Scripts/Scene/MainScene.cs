using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    private void Awake() {
        MainManager.GetInstance();
        UIManager.GetInstance().SetEventSystem();
        UIManager.GetInstance().OpenUI("UIMain");
    }
}
