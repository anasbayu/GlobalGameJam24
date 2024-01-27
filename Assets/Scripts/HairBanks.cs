using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairBanks : MonoBehaviour{
    public List<GameObject> rambuts = new List<GameObject>();
    int currIndex = 0;

    public GameObject NextRambut(){
        GameObject rambut = rambuts[currIndex];
        currIndex++;

        if(currIndex == rambuts.Count){
            currIndex = 0;
        }

        return rambut;
    }
}
