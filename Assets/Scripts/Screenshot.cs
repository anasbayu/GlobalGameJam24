using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Screenshot : MonoBehaviour
{
    public Linker mLinker;
    public RawImage img;
    string imgPath;
    void Update(){
        if(Input.GetKeyDown(KeyCode.S) && mLinker.mQuestManager.isAbleToContinue){
            mLinker.mAudioManager.PlaySFX("Snapshoot");
            string folderPath = "/Screenshots/";
            string currTime = System.DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");
            imgPath = currTime + "_" + Random.Range(0,1000).ToString() + ".png";

            ScreenCapture.CaptureScreenshot(imgPath);

            GetPhoto();
        }
    }

    public void GetPhoto()
	{	
		string url = Application.persistentDataPath +"/"+ imgPath;
		var bytes = System.IO.File.ReadAllBytes(url);
		Texture2D texture = new Texture2D(73, 73);
		texture.LoadImage(bytes);
		img.texture = texture ;
	}
}
