using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip mShocked, mLaugh, mClown;
    public AudioSource mSourceSFX;

    public void PlaySFX(string mode){
        if(mode == "Shocked"){
            mSourceSFX.clip = mShocked;
        }
        if(mode == "Laugh"){
            mSourceSFX.clip = mLaugh;
        }
        if(mode == "Clown"){
            mSourceSFX.clip = mClown;
        }
        mSourceSFX.Play();
    }
}
