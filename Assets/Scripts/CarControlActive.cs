using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject PcCar;


    void Start()
    {
        CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        PcCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl>().enabled = true;
    }

   
}
