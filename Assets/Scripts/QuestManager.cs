using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Linker mLinker;
    public List<string> questText;
    public List<string> hairstyleName;
    public List<string> responseOKText;
    public List<string> responseWrongText;
    int currQuestIndex = 0;
    int lastQuestIndex = 0;
    public bool isAbleToContinue = false;

    void Start(){        
        GetRandomQuest();
    }

    public void GetRandomQuest(){
        isAbleToContinue = false;
        int questIndex = Random.Range(0, questText.Count);
        // Never get the same quest as the last quest.
        while(questIndex == lastQuestIndex){
            questIndex = Random.Range(0, questText.Count);
        }

        currQuestIndex = questIndex;
        lastQuestIndex = currQuestIndex;
        mLinker.mUIManager.mTxtQuest.text = questText[questIndex];
    }

    public bool CheckQuest(string styleName){
        isAbleToContinue = true;

        if(hairstyleName[currQuestIndex] == styleName){
            mLinker.mGameManager.AddScore();
            mLinker.mUIManager.mTxtQuest.text = responseOKText[Random.Range(0, responseOKText.Count)];
            return true;
        }else{
            mLinker.mGameManager.MinusScore();
            mLinker.mUIManager.mTxtQuest.text = responseWrongText[Random.Range(0, responseWrongText.Count)];
            return false;
        }
    }
}
