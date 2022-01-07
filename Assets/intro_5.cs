using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro_5 : MonoBehaviour
{
    public GameObject introPanel;
    // Start is called before the first frame update
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Person")
        {
            introPanel.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Person")
        {
            introPanel.SetActive(false);
        }
    }
}
