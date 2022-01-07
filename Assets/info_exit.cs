using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_exit : MonoBehaviour
{
    public GameObject infoPanel;
    // Start is called before the first frame update
    // Update is called once per frame
    public void OnBtn()
    {
        infoPanel.SetActive(false);
    }
}