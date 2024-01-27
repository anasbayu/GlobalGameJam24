using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionBanks : MonoBehaviour{
    public List<GameObject> expressions = new List<GameObject>();
    int currIndex = 0;

    public GameObject NextRambut(){
        GameObject expression = expressions[currIndex];
        currIndex++;

        if(currIndex == expressions.Count){
            currIndex = 0;
        }

        return expression;
    }
}
