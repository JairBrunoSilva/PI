using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiscadorZonaCola : MonoBehaviour
{
    public float timePiscada, timePiscadaMax;
    public float timeAceso, timeAcesoMax;
    public bool horaDePiscar;
  

    void Update()
    {
        if (!horaDePiscar) {
            timePiscada -= Time.deltaTime;
        }
        if (horaDePiscar)
        {
            timeAceso -= Time.deltaTime;
        }
    }
    void OnTriggerStay2D (Collider2D collision)
    {
        
    }
}
