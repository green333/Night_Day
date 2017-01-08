using UnityEngine;
using System.Collections;

public class SceneTitle : BaseScene {



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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextScene(nextSceneName);
        }

	}



}
