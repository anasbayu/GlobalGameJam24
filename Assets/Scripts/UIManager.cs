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
    public Button mBtnFinish, mBtnSwap;
    public GameObject mAlbum, mCamFrame;


    void Start(){
        mOvelray.SetActive(false);
    }

    public void ShowOverlay(bool isShown){
        mOvelray.SetActive(isShown);
    }

    public void ShowAlbum(bool isShown){
        mAlbum.SetActive(isShown);
    }

    public void ShohCamFrame(bool isShown){
        mCamFrame.SetActive(isShown);
    }

    public void UpdateScore(string newScore){
        mTxtScore.text = newScore;
    }

    public void EnableButton(bool isEnabled){
        mBtnFinish.gameObject.SetActive(isEnabled);
        mBtnSwap.enabled = isEnabled;
        mTxtSpaceToContinue.gameObject.SetActive(!isEnabled);
    }

    public void PasueGame(){
        mLinker.mGameManager.PasueGame();
    }
}
