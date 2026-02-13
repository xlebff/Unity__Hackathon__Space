using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField]
    private Button[] buttons;

    public void Change()
    {
        foreach (var button in buttons)
        {
            if (button.gameObject.activeSelf) button.gameObject.SetActive(false);
            else button.gameObject.SetActive(true);
        }
    }
}
