using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBox : MonoBehaviour
{
    //GameobjectMenu
    [SerializeField] private Canvas m_menu;

    void Start()
    {
        m_menu.enabled = false;
    }

    void Update()
    {
        //if menuactiv and escape 
        if (m_menu.isActiveAndEnabled && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_menu.enabled = true;

        }
    }
}
