using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mOvelray;

    void Start(){
        mOvelray.SetActive(false);
    }

    public void ShowOverlay(bool isShown){
        mOvelray.SetActive(isShown);
    }
}
