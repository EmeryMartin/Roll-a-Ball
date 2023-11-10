using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winTextObject;


    void Start()
    {
        winTextObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        winTextObject.SetActive(true);
    }


}
