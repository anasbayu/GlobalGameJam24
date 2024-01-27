using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour{
    public Linker mLinker;
    float speed = 10f;
    public GameObject rambutPos;
    public GameObject currRambut;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            mLinker.mGameManager.PasueGame();
        }

        if(Input.GetKeyDown(KeyCode.Space) && mLinker.mQuestManager.isAbleToContinue){
            mLinker.mQuestManager.GetRandomQuest();
            mLinker.mUIManager.EnableButton(true);
        }
    }

    public void SwapRambut(){
        GameObject tmpRambut = mLinker.mHairBanks.NextRambut();
        if(currRambut != null){
            Destroy(currRambut);
        }
        currRambut = Instantiate(tmpRambut, rambutPos.transform.position, Quaternion.identity);
        currRambut.gameObject.name = tmpRambut.gameObject.name;
    }

    public void Finish(){
        // if(mLinker.mQuestManager.isAbleToContinue){
            mLinker.mQuestManager.CheckQuest(currRambut.gameObject.name);   
            mLinker.mUIManager.EnableButton(false);
        // }
    }

    
}
