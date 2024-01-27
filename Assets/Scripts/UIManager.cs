using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Linker mLinker;
    public GameObject mOvelray;
    public TMP_Text mTxtQuest;
    public TMP_Text mTxtScore;
    public TMP_Text mTxtSpaceToContinue;
    public Button mBtnFinish;


    void Start(){
        mOvelray.SetActive(false);
    }

    public void ShowOverlay(bool isShown){
        mOvelray.SetActive(isShown);
    }

    public void UpdateScore(string newScore){
        mTxtScore.text = newScore;
    }

    public void EnableButton(bool isEnabled){
        mBtnFinish.interactable = isEnabled;

        mTxtSpaceToContinue.gameObject.SetActive(!isEnabled);
    }

    public void PasueGame(){
        mLinker.mGameManager.PasueGame();
    }
}
