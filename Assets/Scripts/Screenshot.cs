using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public Linker mLinker;
    void Update(){
        if(Input.GetKeyDown(KeyCode.S) && mLinker.mQuestManager.isAbleToContinue){
            mLinker.mAudioManager.PlaySFX("Snapshoot");
            string currTime = System.DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");
            string folderPath = "/Screenshots/";

            ScreenCapture.CaptureScreenshot(currTime 
                + "_" + Random.Range(0,1000).ToString() + ".png");
        }
    }
}
