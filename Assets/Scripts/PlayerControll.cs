using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour{
    public Linker mLinker;
    float speed = 10f;
    public GameObject rambutPos;
    public GameObject currRambut, currEkspresi;

    void Start(){
        // Randomize NPC expression & hairstyle.
        SwapRambut();
        SpawnEkspresi("satisfied");
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            mLinker.mGameManager.PasueGame();
        }

        if(Input.GetKeyDown(KeyCode.Space) && mLinker.mQuestManager.isAbleToContinue){
            mLinker.mQuestManager.GetRandomQuest();
            mLinker.mUIManager.EnableButton(true);
            SpawnEkspresi("satisfied");
        }

        if(Input.GetKeyDown(KeyCode.S) && mLinker.mQuestManager.isAbleToContinue){
            mLinker.mUIManager.mCamFrame.SetActive(true);
        }
    }

    public void TakeASnap(){
        mLinker.mAudioManager.PlaySFX("Snapshoot");
        mLinker.mScreenshot.TakeASnap();

        // TODO: Add snap/blitz effect.
        mLinker.mUIManager.mCamFrame.SetActive(false);
    }

    public void SwapRambut(){
        GameObject tmpRambut = mLinker.mHairBanks.NextRambut();
        if(currRambut != null){
            Destroy(currRambut);
        }
        currRambut = Instantiate(tmpRambut, rambutPos.transform.position, Quaternion.identity);
        currRambut.gameObject.name = tmpRambut.gameObject.name;
    }

    public void SpawnEkspresi(string expression){
        GameObject tmpEkspresi = mLinker.mExpressionBanks.GetExpression(expression);
        
        if(currEkspresi != null){
            Destroy(currEkspresi);
        }
        currEkspresi = Instantiate(tmpEkspresi, rambutPos.transform.position, Quaternion.identity);
        currEkspresi.gameObject.name = tmpEkspresi.gameObject.name;
    }

    public void Finish(){
        bool isSatisfied = mLinker.mQuestManager.CheckQuest(currRambut.gameObject.name);   
        if(isSatisfied){
            mLinker.mAudioManager.PlaySFX("Clown");
            SpawnEkspresi("satisfied");
        }else{
            string[] modes = {"Laugh", "Shocked"};
            mLinker.mAudioManager.PlaySFX(modes[Random.Range(0,modes.Length)]);
            SpawnEkspresi("disatisfied");
        }
        mLinker.mUIManager.EnableButton(false);
    }
}
