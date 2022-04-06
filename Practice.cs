using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    /// <summary>
    /// 変数
    /// </summary>
    private float seconds =1;
    private int number = 1;
    private bool countStop;
    
    void Start()
    {
        
    }

    /// <summary>
    /// クラス
    /// </summary>
    void DispleyNumber() //実行したらLogにnumberを表示、numberをインクリメント、secondsを0にリセット。
    {

        
        Debug.Log(number);
        number++;
        seconds = 0;

    }

    void CountTime()　//Time.deltaTimeで時間を調整
    {
        seconds += Time.deltaTime;　
    }

    
    void Update()
    {
        /* */

        if (seconds > 1)　//一秒ごとにDispleyNumberを実行
        {
            DispleyNumber();
        }

        if (countStop == false) //条件が満たされるまでCountTimeを作動
        {
            CountTime();
        }

        if (number > 10) //number(秒数)が10秒に達したらcountStopをtrueに
        {
            countStop = true;
        }


    }
}
