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
    public float car_price;
    float price_vessel;

    //additions
    public List<CarAdditions> car_add_ons;




    // Start is called before the first frame update
    void Start()
    {
        price_vessel = car_price;
    }

    public float FinalPrice()
    {
        float tempPrice = price_vessel;

        if(car_add_ons.Count > 0)
        {
            for (int index = 0; index < car_add_ons.Count; index++)
            {
                car_price += tempPrice / 10;
            }
        }
        

        return car_price;
    }
}
