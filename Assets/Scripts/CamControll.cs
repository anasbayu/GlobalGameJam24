using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControll : MonoBehaviour
{
    public Transform camPos1, camPos2, camPos3, camPos4;
    public GameObject cam, target;
    int currViewIndex;

    void Start(){
        currViewIndex = 1;
        transform.LookAt(target.transform.position);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.V)){
            if(currViewIndex == 4){
                currViewIndex = 1;
            }else{
                currViewIndex++;
            }

            if(currViewIndex == 1){
                cam.transform.position = camPos1.position;
            }else if(currViewIndex == 2){
                cam.transform.position = camPos2.position;
            }else if(currViewIndex == 3){
                cam.transform.position = camPos3.position;
            }else{
                cam.transform.position = camPos4.position;
            }

            transform.LookAt(target.transform.position, new Vector3(0, 5, 0));
        }
    }
}
