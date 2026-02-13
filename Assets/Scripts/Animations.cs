using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField]
    private GameObject dead;

    private void OnDisable()
    {
        dead.SetActive(true);    
    }
}
