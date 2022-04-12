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


    void ComputeAge()
    {
        Debug.Log(5 + 4 - 3 / 2 * 1);
        Debug.Log(5 + (4 - 3) / 2 * 1);
    }

    void Start()
    {
        Debug.Log($"文字列には{firstName}のような変数を挿入できる！");

        //Debug.Log(firstName * pi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
