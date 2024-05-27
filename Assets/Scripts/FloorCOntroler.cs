using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCOntroler : MonoBehaviour
{
    public float life = 20;
    void Update()
    {
        life -= Time.deltaTime;
        if(life <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(-2.5f * Time.deltaTime, 0,0) ;
        }
    }
}
