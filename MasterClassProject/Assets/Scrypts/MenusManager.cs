using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenusManager : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject InGameMenu;

    public CarManager car;
    public int car_index = 0;

    public Slider red_slider;
    public Slider green_slider;
    public Slider blue_slider;

    public TextMeshProUGUI price;
    public TextMeshProUGUI namec;

    // Start is called before the first frame update
    void Start()
    {
        ColorUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        namec.text = car.cars_list[car_index].car_name;
        price.text = car.cars_list[car_index].FinalPrice().ToString();
       
    }

    public void StartTriggerred()
    {
        StartMenu.SetActive(false);
        InGameMenu.SetActive(true);
    }

    public void ExitTriggerred()
    {
        Application.Quit();
    }

    public void BackButtonTrriggerred()
    {
        InGameMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void OnLeftButtonClicked()
    {
        if (car_index >= 1)
        {
            car.cars_list[car_index].gameObject.SetActive(false);
            car_index--;
            car.cars_list[car_index].gameObject.SetActive(true);
           
        }
    }

    public void OnRightButtonClicked()
    {
        if (car_index < car.cars_list.Count - 1)
        {
            car.cars_list[car_index].gameObject.SetActive(false);
            car_index++;
            car.cars_list[car_index].gameObject.SetActive(true);
           
        }
    }

    public void ColorUpdate()
    {
        car.cars_list[car_index].car_color.color = new Color(red_slider.value /255, green_slider.value/255, blue_slider.value/255);
    }

    public void CalculatePrice()
    {
        car.cars_list[car_index].FinalPrice();
    }
}
