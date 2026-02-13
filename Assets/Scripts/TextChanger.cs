using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField]
    private TMP_Text info;
    [SerializeField]
    private TMP_Text lable;

    public void LableSet(string text)
    {
        lable.text = "";    
        StartCoroutine(Lable(text));
    }
    public void InfoSet(string text)
    {
        info.text = "";
        StartCoroutine(Writing(text));
    }

    private IEnumerator Writing(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            info.text += text[i];
            yield return new WaitForSeconds(0.02f);
        }
    }
    private IEnumerator Lable(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            lable.text += text[i];
            yield return new WaitForSeconds(0.02f);
        }
    }
}
