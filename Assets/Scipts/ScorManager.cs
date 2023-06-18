using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorManager : MonoBehaviour
{
    public Text skor_tx;
    public static float skor;

    void Start()
    {
        skor = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        skor_tx.text = skor.ToString();
        
    }
}
