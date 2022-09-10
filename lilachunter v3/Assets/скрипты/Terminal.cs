using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Terminal : MonoBehaviour
{
    [SerializeField]
    Animator ventaAnimator;
    [SerializeField]
    Button but;
    [SerializeField]
    Canvas DoorMessage;
    [SerializeField]
    float openTerminal;
    [SerializeField]
    float closeTerminal;
    float speed = 1;
    private string openTrigger = "open";
    public bool isOpen;
    public int id;
    public bool isLocked = true;


    void Start()
    {
        but.onClick.AddListener(OpenTerminal);
        DoorMessage.gameObject.SetActive(false);
    }



    private void OnCollisionEnter(Collision collision)
    {
        DoorMessage.gameObject.SetActive(true);

    }
    private void OnCollisionExit(Collision collision)
    {
        DoorMessage.gameObject.SetActive(false);

    }

    void OpenTerminal()
    {
        

        if (isLocked == true)
        {
            return;
        }
        else if (isLocked == false)
        {
            ventaAnimator.SetTrigger(openTrigger);
        }

    }
    private void OnDestroy()
    {

        if (DoorMessage)
        {
            DoorMessage.gameObject.SetActive(false);
        }


    }


}
