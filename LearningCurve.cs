using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;
    
    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;


    void Start()
    {
        Debug.Log("PleaseSelectPlayer");
        GenerateCharacter();
        Debug.Log("NiceChoise!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateCharacter()
    {
        Debug.Log("select Kazu");
    }

}
