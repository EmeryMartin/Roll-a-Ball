using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marketTrigger : MonoBehaviour
{
    public GameObject beacon;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        beacon.SetActive(false);
        trigger.SetActive(false);
    }
}
