using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarAdditions : MonoBehaviour
{
    public Toggle addition_button;

    //additional equipment name
    public string equipment_name;

    //equipment price
    public float equipment_price;

    public bool active = false;

    public void OnButtonTapped()
    {
        if(!addition_button.isOn)
        {
            active = false;            
        }
        else
        {
            active = true;         
        }
    }

}
