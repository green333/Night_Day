using UnityEngine;
using System.Collections;

public class BaseHuman : MonoBehaviour {


    [SerializeField]
    private Rigidbody rigid;

    [SerializeField]
    private float move_spd;     //移動速度

    [SerializeField]
    private float rotate_spd;   //回転速度

    //private int act_state;   //モーションステート

    protected enum ACT_STATE
    {
        WAIT = 0,     //待機
        MOVE,         //移動
        ATTACK,       //攻撃

    }

    [SerializeField]
    private ACT_STATE act_state;   //モーションステート



    //----------------------------------------

    //  初期化
    //  詳細な説明:特になし

    //----------------------------------------
    protected virtual void Start () {
	
	}


    //----------------------------------------

    //  更新
    //  詳細な説明:特になし

    //----------------------------------------
    protected virtual void Update () {

        switch (act_state)
        {
            case ACT_STATE.WAIT:
                break;

            case ACT_STATE.MOVE:
                Move();
                break;

            case ACT_STATE.ATTACK:
                break;
        }

	}



    void Move()
    {
        float dx = Input.GetAxis("Horizontal");
        float dz = Input.GetAxis("Vertical");


        transform.Translate(0.0F, 0.0F, dz * move_spd);

        transform.Rotate(0.0F, dx * rotate_spd, 0.0F);

    }



}
