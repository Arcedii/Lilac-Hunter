using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TerminaController : MonoBehaviour
{
    [SerializeField]
    Button but;
    [SerializeField]
    Button but1;
    private string openTrigger = "open";
    public float distance = 2f;
    public static Action OnKeyFound;
    List<Key> keyList;

    void Start()
    {
        but.onClick.AddListener(OpenTerminal);
        but1.onClick.AddListener(OpenTerminal);
        keyList = new List<Key>();
        but1.gameObject.SetActive(false);

    }


    void OpenTerminal()
    {

        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.tag == "Terminal")
            {
                Terminal Terminal = hit.collider.GetComponent<Terminal>();
                for (int i = 0; i < keyList.Count; i++)
                {
                    if (keyList[i].id == Terminal.id)
                    {
                        Terminal.isLocked = false;
                        Terminal.isOpen = !Terminal.isOpen;
                        keyList.Remove(keyList[i]);
                    }
                    else
                    {

                        Debug.Log("Не тот ключ");
                    }



                }

            }
            if (hit.collider.GetComponent<Key>())
            {
                OnKeyFound?.Invoke();
                Key key = hit.collider.GetComponent<Key>();
                keyList.Add(key);
                Debug.Log(keyList.Count);
                Destroy(key.gameObject);
            }


        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("keyfinnal"))
        {
            but1.gameObject.SetActive(true);
        }
       

    }
    private void OnCollisionExit(Collision collision)
    {
        but1.gameObject.SetActive(false);

    }

}
