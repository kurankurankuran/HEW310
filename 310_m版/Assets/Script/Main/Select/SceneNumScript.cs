using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNumScript : MonoBehaviour
{
    [Header("ゲームシーン番号")]
    [SerializeField]
    private int SceneNum = 0;


    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public int GetSceneNum()
    {
        return SceneNum;
    }
}
