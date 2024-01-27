using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject mCredit;
    public void Load(string sceneName){
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void ShowCredits(){
        mCredit.SetActive(true);
    }

    public void CloseCredits(){
        mCredit.SetActive(false);
    }
}
