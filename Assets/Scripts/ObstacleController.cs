using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float sentTimer = 1;
    public float Frecuency = 2;
    public float position;
    public GameObject myObstacle;
    public GameObject Characte;

    private void Update()
    {
        sentTimer -= Time.deltaTime;
        if(sentTimer <= 0)
        {
            position = Random.Range(.68f, 2f);
            transform.position = new Vector3(3.9f, position, -3.7f);
            Instantiate(myObstacle, transform.position, transform.rotation);
            sentTimer = Frecuency;
        }
        if(Characte != null)
        {
            Time.timeScale = 1;

        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
