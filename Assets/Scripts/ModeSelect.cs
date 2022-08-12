using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{


    public static int TipTrke; // 0 = Race, 1 = score , 2 = time
    public GameObject TrackSelect;

    public void RaceMode()
    {
        TipTrke = 0;
        TrackSelect.SetActive(true);

    }
    public void ScoreMode()
    {
        TipTrke = 1;
        TrackSelect.SetActive(true);
    }

    public void TimeMode()
    {
        TipTrke = 2;
        TrackSelect.SetActive(true);

    }

    
}
