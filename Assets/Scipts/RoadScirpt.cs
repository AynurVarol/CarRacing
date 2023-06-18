using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScirpt : MonoBehaviour
{
    public GameObject road;
    bool yol_tamamlandi = false;

    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.tag == "mainCar" && yol_tamamlandi == false)
        {
            Vector3 spawnlokasyon = new Vector3(transform.position.x, transform.position.y + -23, 0);
            Instantiate(road,spawnlokasyon, Quaternion.identity);
            yol_tamamlandi = true;
            ScorManager.skor += 10;
            Destroy(this.gameObject,6f);
        }
    }
   
}
