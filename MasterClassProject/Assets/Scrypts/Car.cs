using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : ScriptableObject
{
    //car name
    public string car_name;

    //car model
    public GameObject car_prefab;

    //values for changing the car color
    public int car_red_color_value = 0;         
    public int car_green_color_value = 0;
    public int car_blue_color_value = 0;

    //car price
    float car_price;

    //additions

}
