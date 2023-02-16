using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenusManager : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject InGameMenu;

    public Dropdown additions_dropdown;
    public CarManager car;
    int car_index = 0;

    public Slider red_slider;
    public Slider green_slider;
    public Slider blue_slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            car_index--;
        }
    }

    public void OnRightButtonClicked()
    {
        if (car_index < car.cars_list.Count)
        {
            car_index++;
        }
    }

    public void ColorUpdate()
    {
        car.cars_list[car_index].car_color.color = new Color(red_slider.value, green_slider.value, blue_slider.value, 1);
    }
}
