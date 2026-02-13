using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    [SerializeField]
    private StarsList list;
    [SerializeField]
    private SliderMove slider;
    [SerializeField]
    private Buttons buttons;
    [SerializeField]
    private GameObject first;
    [SerializeField]
    private TextChanger changer;
    [SerializeField]
    private AudioSource choise;

    private int status = 0;

    private void OnEnable()
    {
        changer.LableSet(list.validName[0]);
        changer.InfoSet(list.validInfo[0]);
        list.validStars[0].gameObject.SetActive(true);
    }

    public void Next()
    {
        if (status < list.validStars.Length - 1)
        {
            choise.Play();
            changer.StopAllCoroutines();
            list.validStars[status].gameObject.SetActive(false);
            status++;
            changer.InfoSet(list.validInfo[status]);
            changer.LableSet(list.validName[status]);
            list.validStars[status].gameObject.SetActive(true);
        }
    }

    public void Back()
    {
        if (status > 0)
        {
            choise.Play();
            changer.StopAllCoroutines();
            list.validStars[status].gameObject.SetActive(false);
            status--;
            list.validStars[status].gameObject.SetActive(true);
            changer.LableSet(list.validName[status]);
            changer.InfoSet(list.validInfo[status]);
        }
    }

    public void Off()
    {
        buttons.Change();
        changer.StopAllCoroutines();
        changer.LableSet("Протозвезда");
        changer.InfoSet(list.first);
        list.validStars[status].gameObject.SetActive(false);
        first.SetActive(true);
        status = 0;
        slider.enabled = true;
        this.enabled = false;
    }
}
