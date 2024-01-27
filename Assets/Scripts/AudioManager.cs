using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip mShocked, mLaugh, mClown, mSnapshoot;
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
        if(mode == "Snapshoot"){
            mSourceSFX.clip = mSnapshoot;
        }
        mSourceSFX.Play();
    }
}
