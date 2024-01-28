using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Screenshot : MonoBehaviour
{
    public Linker mLinker;
    public Image img1, img2, img3, img4, img5;
    public GameObject polaroid1, polaroid2, polaroid3, polaroid4, polaroid5;
    int currPolaroidIndex;

    void Start(){
        currPolaroidIndex = 1;
    }

    IEnumerator RecordFrame()
    {
        yield return new WaitForEndOfFrame();
        Texture2D rawScreenshoot = ScreenCapture.CaptureScreenshotAsTexture();
        Texture2D screenshoot = new Texture2D(rawScreenshoot.width, rawScreenshoot.height, TextureFormat.RGB24, false);
        screenshoot.SetPixels(rawScreenshoot.GetPixels());
        screenshoot.Apply();

        // cleanup
        Destroy(rawScreenshoot);

        // Convert to Sprite.
        Sprite screenshootToDisplay = Sprite.Create(screenshoot, new Rect(0, 0, screenshoot.width, screenshoot.height), 
            new Vector2(0.5f, 0.5f));

        if(currPolaroidIndex == 1){
            polaroid1.SetActive(true);
            img1.sprite = screenshootToDisplay;
        }else if(currPolaroidIndex == 2){
            polaroid2.SetActive(true);
            img2.sprite = screenshootToDisplay;
        }else if(currPolaroidIndex == 3){
            polaroid3.SetActive(true);
            img3.sprite = screenshootToDisplay;
        }else if(currPolaroidIndex == 4){
            polaroid4.SetActive(true);
            img4.sprite = screenshootToDisplay;
        }else if(currPolaroidIndex == 5){
            polaroid5.SetActive(true);
            img5.sprite = screenshootToDisplay;
        }

        currPolaroidIndex++;
    }

    public void TakeASnap(){
        StartCoroutine(RecordFrame());
    }
}
