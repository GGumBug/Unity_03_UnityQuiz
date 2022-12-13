using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainButton : MonoBehaviour
{
    public Button btnQuizType;
    public TMP_Text txtQuizType;

    public void SetReference()
    {
        btnQuizType = GetComponent<Button>();
        txtQuizType = GetComponentInChildren<TMP_Text>();
    }

}
