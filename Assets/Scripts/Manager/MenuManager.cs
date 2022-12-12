using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    #region SingleTone
    public static MenuManager Instance;

    public static MenuManager GetInstance()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("@MenuManager");
            Instance = go.AddComponent<MenuManager>();

            DontDestroyOnLoad(go);
        }

        return Instance;
    }
    #endregion


}
