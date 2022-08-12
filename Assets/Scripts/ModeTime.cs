using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModeTime : MonoBehaviour
{

    public int izabraniTip;
    public GameObject PcCar;
    public static bool isTimeMode = false;

    // Start is called before the first frame update
    void Start()
    {
        izabraniTip = ModeSelect.TipTrke;  
        
        if(izabraniTip == 2)
        {
            isTimeMode = true;
            PcCar.SetActive(false);
        }
    }

   

}
