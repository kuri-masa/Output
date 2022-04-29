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
        // int characterLevel = 32;

        GenerateCharacter();
    }

    void Update()
    {
        
    }

    void GenerateCharacter()
    {
        Debug.Log($"Character:{firstName} - Level:{currentAge} ");
    }

}
