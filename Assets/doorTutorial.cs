using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTutorial : MonoBehaviour
{
    void OnTriggerEnter (Collider other){
        Debug.Log ("Object Entered the trigger");
    }
    void OnTriggerStay (Collider other){
        string colliderObject = other.name;
        string objectName = gameObject.name;
        Debug.Log (colliderObject + " Object is within trigger");
        if(String.Equals(colliderObject, "GrabVolumeCone") ){
            switch (objectName){
                case "Door_Home":
                    SceneManager.LoadScene("Home"); break;
                case "Door_Freeplay":
                    SceneManager.LoadScene("Freeplay"); break;
                case "Door_Tutorial":
                    SceneManager.LoadScene("Tutorial 1"); break;
                case "Door_Tutorial1":
                    SceneManager.LoadScene("Tutorial 2"); break;
                case "Door_Tutorial2":
                    SceneManager.LoadScene("Tutorial 3"); break;
                case "Door_Tutorial3":
                    SceneManager.LoadScene("Tutorial 4"); break;
                case "Door_Tutorial4":
                    SceneManager.LoadScene("Tutorial 5"); break;
                case "Door_Tutorial5":
                    SceneManager.LoadScene("Tutorial 6"); break;
                case "Door_Tutorial6":
                    SceneManager.LoadScene("Tutorial 7"); break;
            }
        }
    }
    void OnTriggerExit (Collider other){
        Debug.Log ("Object Exited the trigger");
    }
}
