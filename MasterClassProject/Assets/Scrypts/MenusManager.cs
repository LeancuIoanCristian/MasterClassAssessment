using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusManager : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject InGameMenu;
   
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
}
