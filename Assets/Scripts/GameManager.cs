using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Linker mLinker;
    bool isGamePaused = false;
    int score;

    void Start(){
        score = 0;
    }

    public void PasueGame(){
        isGamePaused = !isGamePaused;
        mLinker.mUIManager.ShowOverlay(isGamePaused);
    }

    public void AddScore(){
        score++;
        mLinker.mUIManager.UpdateScore(score.ToString());
    }

    public void MinusScore(){
        if(score >0){
            score--;
            mLinker.mUIManager.UpdateScore(score.ToString());
        }
    }
}
