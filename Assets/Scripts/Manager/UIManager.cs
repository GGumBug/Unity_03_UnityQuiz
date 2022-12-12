using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UIManager : MonoBehaviour
{
    #region SingleTone
    public static UIManager Instance;

    public static UIManager GetInstance()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("@UIManager");
            Instance = go.AddComponent<UIManager>();
            
            DontDestroyOnLoad(go);
        }

        return Instance;
    }
    #endregion

    public GameObject SetEventSystem()
    {
        if (FindObjectOfType<EventSystem>() == false)
        {
            GameObject go = new GameObject("EventSystem");
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
                    
            return go;
        }
        else
        {
            return null;
        }

    }

    public GameObject OpenUI(string PrefabName)
    {
        Object obj = Resources.Load("UI/" + PrefabName);
        GameObject go = (GameObject)Instantiate(obj);

        return go;
    }
}
