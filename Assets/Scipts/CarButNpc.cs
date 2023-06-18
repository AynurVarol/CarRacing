using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarButNpc : MonoBehaviour
{
    private float varsayilan_hiz;
    private int gidilenşerit;
    public int car_sprite;
    public Sprite car1, car2, car3, car4, car5, car6, car7;
    Rigidbody rb;
    SpriteRenderer spr;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody>();

        gidilenşerit = Random.Range(1, 5);
        varsayilan_hiz = Random.Range(2.5f, 3.5f);
        car_sprite = Random.Range(1,8);

        if(gidilenşerit == 1)
        {
            transform.position = new Vector3(113.5f, transform.position.y + 10, 0);

        }

        else if(gidilenşerit == 2)
        {
            transform.position = new Vector3(121.4f, transform.position.y + 10, 0);

        }

         switch (car_sprite)
         {
            case 1:
                 spr.sprite = car1;
                 break;
            
            case 2:
                 spr.sprite = car2;
                 break;

            case 3:
                 spr.sprite = car3;
                 break;
            
            case 4:
                 spr.sprite = car4;
                 break;
            
            case 5:
                 spr.sprite = car5;
                 break;

            case 6:
                 spr.sprite = car6;
                 break;

            case 7:
                 spr.sprite = car7;
                 break;

         }
 
    }

    // Update is called once per frame
    void FxedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, varsayilan_hiz * 50 * Time.deltaTime, 0);
        
    }

    void OnCollisionEnter(Collision temas)
    {
        if(temas.gameObject.tag == "mainCar")
        {
            SceneManager.LoadScene(2);

        }
    }

    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.tag == "Sollama")
        {
            ScorManager.skor += 30;
        }
    }
}
