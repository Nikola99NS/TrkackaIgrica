using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalCash : MonoBehaviour
{

    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;
    
    void Start()
    {
        
        TotalCash = PlayerPrefs.GetInt("SavedCash") + ModeScore.CurrentScore;
        
    }

   
    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<TMP_Text>().text = "Cash $" + CashValue;
    }
}
