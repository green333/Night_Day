using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;



//-----------------------------------------------------------------------------

//  基本シーンクラス

//-----------------------------------------------------------------------------


public class BaseScene : MonoBehaviour {

    [SerializeField]
    protected string nextSceneName;

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

    }


    //----------------------------------------

    //  次のシーンへ移る
    //  詳細な説明:引数のnameは次へ移るシーン名

    //----------------------------------------
    protected void NextScene(string filename)
    {
        nextSceneName = filename;

        if (string.IsNullOrEmpty(nextSceneName)) return;

        SceneManager.LoadScene(nextSceneName);
    }

}
