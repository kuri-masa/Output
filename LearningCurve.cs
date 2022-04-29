using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int diceRoll = 7;
    public bool check ;
    
    void Start()
    {
        
    }

    void Action()
    {
        switch(diceRoll)
        {
            case 7:
                Debug.Log("7");
                break;
            case 15:
                Debug.Log("15");
                break;
            case 20:
                Debug.Log("20");
                break;
            default:
                Debug.Log("Failure");
                break;
        }
    }

    void Update()
    {
        if(check)
        {
            Action();
            check = false;
        }
    }

   
}
