using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PosUp : MonoBehaviour
{

    public GameObject positionDisplay;
    
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPos")
        {
            positionDisplay.GetComponent<TMP_Text>().text = "1st place";
        }
    }
}
