using UnityEngine;
using System.Collections;

using UnityEngine.UI;


public class Clock : MonoBehaviour {

    [SerializeField]
    private Image long_needle;   //長い針

    [SerializeField]
    private Image short_needle;  //短い針

    [SerializeField]
    private int now_time;    //現在の時間

    [SerializeField]
    private int time_spd = 10;    //経過時間速度

    [SerializeField]
    private NightDay day;

    private float seconds;   //秒

    private float minute;    //分

    private const int MAX_TIME = 12;   //時間1-12
    private const int ONE_MINUTE = 1;  //1分

    private int minute_count = ONE_MINUTE;       //1時間ごとに12カウントさせる1-12



    //----------------------------------------

    //  初期化
    //  詳細な説明:特になし

    //----------------------------------------
    void Start () {
	
	}


    //----------------------------------------

    //  更新
    //  詳細な説明:特になし

    //----------------------------------------
    void Update () {

        ClockTime();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            time_spd--;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            time_spd++;
        }

        if(now_time == 12 * NightDay.now_day)
        {
            NightDay.now_day++;
        }

    }




    //----------------------------------------

    //  時計の分と秒の管理
    //  詳細な説明:特になし

    //----------------------------------------
    void ClockTime()
    {
       
        Clock_Seconds();
        Clock_Minute();
    }


    //----------------------------------------

    //  秒の計算
    //  詳細な説明:特になし

    //----------------------------------------
    void Clock_Seconds()
    {

        if (seconds >= 360)
        {
            seconds = 0;
            minute_count = ONE_MINUTE;
            now_time++;
        }

        seconds += (time_spd * Time.deltaTime);

        long_needle.rectTransform.rotation = Quaternion.Euler(new Vector3(0, 0, -seconds + 90));

    }

    //----------------------------------------

    //  分の計算
    //  詳細な説明:特になし

    //----------------------------------------
    void Clock_Minute()
    {
        if(seconds >= MAX_TIME * minute_count)
        {
            minute++;
            minute_count++;
        }



        short_needle.rectTransform.rotation = Quaternion.Euler(new Vector3(0, 0, -minute + 90));
    }


}
