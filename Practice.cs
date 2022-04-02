using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    float seconds =1;
    int number = 1;
    bool countStop;
    
    void Start()
    {
        
    }

    void DispleyNumber()
    {

        
        Debug.Log(number);
        number++;
        seconds = 0;

    }

    void CountTime()
    {
        seconds += Time.deltaTime;　//Time.deltaTimeで時間を調整
    }


    void Update()
    {
        

        if (seconds > 1)
        {
            DispleyNumber();
        }

        if (countStop == false)
        {
            CountTime();
        }

        if (number > 10)
        {
            countStop = true;
        }


    }
}
