using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrong : MonoBehaviour
{
    public GameObject introPanel;
    public GameObject introPanel_1;
    public GameObject introPanel_2;
    public GameObject introPanel_3;
    public GameObject Wrong;
    // Start is called before the first frame update
    public void OnBtn()
    {
        Wrong.SetActive(true);
        Debug.Log("N");
        introPanel.SetActive(false);
        introPanel_1.SetActive(false);
        introPanel_2.SetActive(false);
        introPanel_3.SetActive(false);
    }
}
