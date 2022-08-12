using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModeScore : MonoBehaviour
{

    public int izabraniTip;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject PcCar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreObjects; 

    // Start is called before the first frame update
    void Start()
    {
        izabraniTip = ModeSelect.TipTrke;  
        
        if(izabraniTip == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            PcCar.SetActive(false);
            ScoreObjects.SetActive(true);
        }
    }

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<TMP_Text>().text = "" + InternalScore;
    }


}
