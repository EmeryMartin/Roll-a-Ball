using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    public TextMeshProUGUI countText;
    public GameObject guideTextObject;
    public GameObject countTextObject;
    public GameObject winTrigger;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();


    }

    void SetCountText()
    {
        countText.text = "Groceries Collected: " + count.ToString() + "/6";
        if (count >= 6)
        {
            guideTextObject.SetActive(true);
            countTextObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

            win();
        }

        SetCountText();
    }
    private void win()
    {
        if(count == 6)
        {
            winTrigger.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
