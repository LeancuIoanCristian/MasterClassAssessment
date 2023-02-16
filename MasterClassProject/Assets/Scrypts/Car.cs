using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //car name
    public string car_name;

    //car model
    public GameObject car_prefab;

    // car color material
    public Material car_color;

    //car price
    public float car_price;
    float price_initial;

    //additions
    public List<CarAdditions> car_add_ons = new List<CarAdditions>();
    public CarAdditions car_heated_seats;
    public CarAdditions car_heated_mirrors;
    public CarAdditions car_power_engine;



    // Start is called before the first frame update
    void Start()
    {
        
        car_add_ons.Add(car_heated_seats);
        car_add_ons.Add(car_heated_mirrors);
        car_add_ons.Add(car_power_engine);
    }
    

    public float FinalPrice()
    {
        float temp_collection = 0;
       
        for (int index = 0; index < car_add_ons.Count; index++)
        {
            if (car_add_ons[index].active)
            {
                temp_collection += car_add_ons[index].equipment_price;
            }
        }
        return car_price + temp_collection;
    }

    
}
