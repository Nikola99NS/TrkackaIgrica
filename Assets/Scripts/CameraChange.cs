using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FirstPersonCam;
    public int CamMode;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FirstPersonCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if(CamMode == 2)
        {
            FirstPersonCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }

}
