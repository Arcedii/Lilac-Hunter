using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CmerraController2 : MonoBehaviour
{
    [SerializeField]
    Canvas Playerstop;
    [SerializeField]
    Button but;
    [SerializeField]
    Canvas DoorMessage;
    public Camera cam1;
    public Camera cam2;
    private bool inTrigger;

    void Start()
    {
        but.onClick.AddListener(Open);
        DoorMessage.gameObject.SetActive(false);
        cam1.enabled = true;
        cam2.enabled = false;
    }
   
    
    void Open()
    {
        if (inTrigger)
        {                      
                cam1.enabled = !cam1.enabled;
                cam2.enabled = !cam2.enabled;
           if (cam2.enabled == true)
           {
                Playerstop.gameObject.SetActive(false);
           }
           else if (cam2.enabled == false)
           {
                Playerstop.gameObject.SetActive(true);
           }
            
        }


    }
    void OnTriggerEnter(Collider switch_camera1)
    {
        inTrigger = true;
        DoorMessage.gameObject.SetActive(true);
        
    }
    void OnTriggerExit(Collider switch_camera1)
    {
        inTrigger = false;
        DoorMessage.gameObject.SetActive(false);
       
    }
   
}
