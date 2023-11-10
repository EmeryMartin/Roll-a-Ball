using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marketTrigger : MonoBehaviour
{
    public GameObject object1;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        object1.SetActive(false);
        trigger.SetActive(false);
    }
}
