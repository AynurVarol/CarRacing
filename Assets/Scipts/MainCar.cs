using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    public float dikeyhiz,yatayhiz, anahiz;
    private float dikeyhareket, yatayhareket;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dikeyhareket = Input.GetAxis("Vertical");
        yatayhareket = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3
        (yatayhareket*50*yatayhiz*Time.deltaTime, anahiz+dikeyhareket*50*dikeyhiz*Time.deltaTime);

        if(transform.position.x > 126f)
        {
            Vector3 right_limit =new Vector3(126f, transform.position.y);
            transform.position = right_limit;
        }
         if(transform.position.x > 118f)
        {
            Vector3 left_limit =new Vector3(118f, transform.position.y);
            transform.position = left_limit;
        }
        
        
    }
}
