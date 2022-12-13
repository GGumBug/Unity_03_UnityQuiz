using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClear : MonoBehaviour
{
    public Button btnReTry;

    public void ConnectObject()
    {
        btnReTry = GetComponentInChildren<Button>();
    }
}
