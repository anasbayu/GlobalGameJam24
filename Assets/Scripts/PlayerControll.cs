using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour{
    public Linker mLinker;
    float speed = 10f;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            mLinker.mGameManager.PasueGame();
        }
    }

    public void SwapRambut(){
        Debug.Log("swap");
    }

    
}
