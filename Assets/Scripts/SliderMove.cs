using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderMove : MonoBehaviour
{
    [SerializeField]
    private StarsList list;
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private Evolution evolution;
    [SerializeField]
    private Buttons buttons;
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private GameObject first;

    private float value;

    private void OnEnable()
    {
        slider.gameObject.SetActive(true);
    }

    private void Update()
    {
        value = (float)Math.Round(slider.value, 2);

        switch (value)
        {
            case < 0.1f:
                text.text = "Менее 0,07 масс Солнца";
                first.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                break;

            case <= 0.15f:
                text.text = "0,15 масс Солнца";
                break;
            case <= 0.2f:
                text.text = "0,27 масс Солнца";
                break;
            case <= 0.25f:
                text.text = "0,39 масс Солнца";
                break;
            case <= 0.3f:
                text.text = "0,5 масс Солнца";
                first.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                break;

            case <= 0.35f:
                text.text = "1,4 масс Солнца";
                break;
            case <= 0.4f:
                text.text = "2,3 масс Солнца";
                break;
            case <= 0.45f:
                text.text = "3 массы Солнца";
                first.transform.localScale = new Vector3(3.5f, 3.5f, 3.5f);
                break;

            case <= 0.5f:
                text.text = "4,25 масс Солнца";
                break;
            case <= 0.55f:
                text.text = "5,5 масс Солнца";
                break;
            case <= 0.6f:
                text.text = "6,75 масс Солнца";
                break;
            case <= 0.65f:
                text.text = "8 масс Солнца";
                first.transform.localScale = new Vector3(4.5f, 4.5f, 4.5f);
                break;

            case <= 0.7f:
                text.text = "8,7 масс Солнца";
                break;
            case <= 0.75f:
                text.text = "9,5 масс Солнца";
                break;
            case <= 0.8f:
                text.text = "10 масс Солнца";
                first.transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
                break;

            case > 0.9f:
                text.text = "Более 10 масс Солнца";
                first.transform.localScale = new Vector3(6.5f, 6.5f, 6.5f);
                break;
        }
    }

    public void Begin()
    {
        value = slider.value;
        if (slider.gameObject.activeSelf)
        {
            switch (value)
            {
                case < 0.1f:
                    list.validInfo = list.listInfo0;
                    list.validName = list.listName0;
                    list.validStars = list.list0;
                    break;
                case <= 0.3f:
                    list.validName = list.listName1;
                    list.validInfo = list.listInfo1;
                    list.validStars = list.list1;
                    break;
                case <= 0.45f:
                    list.validInfo = list.listInfo2;
                    list.validName = list.listName2;
                    list.validStars = list.list2;
                    break;
                case <= 0.65f:
                    list.validInfo = list.listInfo3;
                    list.validName = list.listName3;
                    list.validStars = list.list3;
                    break;
                case <= 0.8f:
                    list.validInfo = list.listInfo4;
                    list.validName = list.listName4;
                    list.validStars = list.list4;
                    break;
                case > 0.9f:
                    list.validInfo = list.listInfo5;
                    list.validName = list.listName5;
                    list.validStars = list.list5;
                    break;
            }
        }

        first.SetActive(false);
        buttons.Change();
        slider.gameObject.SetActive(false);

        evolution.enabled = true;
        this.enabled = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
