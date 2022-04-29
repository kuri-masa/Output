using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public string characterAction = "Attack";
    
    void Start()
    {
        
    }

    void Actioin()
    {
        switch(characterAction)
        {
            case "Heal":
                Debug.Log("Send potion");
                break;
            case "Attack":
                Debug.Log("Fight!");
                break;
            default:
                Debug.Log("Gurde!");
                break;
        }
    }

    void Update()
    {
        Actioin();
    }

   
}
