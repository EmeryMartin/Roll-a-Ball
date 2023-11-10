using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPickUp : MonoBehaviour
{
    public GameObject PickUp;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bred");

        other.gameObject.SetActive(false);
    }
}
