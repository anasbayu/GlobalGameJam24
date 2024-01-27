using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionBanks : MonoBehaviour{
    public List<GameObject> expressions = new List<GameObject>();
    int currIndex = 0;

    public GameObject GetExpression(string expression){
        if(expression == "satisfied"){
            return expressions[0];  // 0 = happy. pastikan di inspector ya.
        }else{
            return expressions[Random.Range(1, expressions.Count)];
        }
    }
}
