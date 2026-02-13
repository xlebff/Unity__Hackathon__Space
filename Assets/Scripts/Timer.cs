using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private int duraction;
    [SerializeField]
    private float time = 0;

    private void OnEnable()
    {
        time = 0;
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= duraction)
        {
            this.gameObject.SetActive(false);
        }
    }
}
