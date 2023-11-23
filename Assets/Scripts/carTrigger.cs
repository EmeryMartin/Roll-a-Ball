using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerSetActive : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject DeathObject;
    public GameObject countText;
    public GameObject guideText;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("crahh");

        targetObject.SetActive(false);
        DeathObject.SetActive(true);
        countText.SetActive(false);
        guideText.SetActive(false);
        
        
    }

}
