using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    float seconds =1;
    int number = 1;

    
    void Start()
    {
        
    }

    void DispleyNumber()
    {
        
        Debug.Log(number);
        number++;
        seconds = 0;

    }



    void Update()
    {

        
        

            DispleyNumber();

        
    }
}
