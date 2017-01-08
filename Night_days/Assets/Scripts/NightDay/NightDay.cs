using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class NightDay : MonoBehaviour {

    [SerializeField]
    private Text text_day;       //テキスト(日数)

    public static int now_day = 1;      //現在の日

    private const int DAY = 1;   //定数（1日)


    //----------------------------------------

    //  初期化
    //  詳細な説明:特になし

    //----------------------------------------
    void Start () {
        text_day.text = now_day.ToString() + "day";
	}


    //----------------------------------------

    //  更新
    //  詳細な説明:特になし

    //----------------------------------------
    void Update () {
        Next_Day(now_day);
	}


    //----------------------------------------

    //  更新
    //  詳細な説明:特になし

    //----------------------------------------


    void Next_Day(int next_day)
    {
        //now_day += next_day;

        text_day.text = now_day.ToString() + "day";
    }


}
