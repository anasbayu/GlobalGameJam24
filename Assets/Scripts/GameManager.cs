using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Linker mLinker;
    bool isGamePaused = false;

    public void PasueGame(){
        isGamePaused = !isGamePaused;
        mLinker.mUIManager.ShowOverlay(isGamePaused);
    }
}
