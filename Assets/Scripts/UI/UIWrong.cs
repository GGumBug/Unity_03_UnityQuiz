using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIWrong : MonoBehaviour
{
    public Button btnReTry;
    public TMP_Text txtScore;

    public void ConnectObject()
    {
        btnReTry = GetComponentInChildren<Button>();
    }
}
