using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    public GameObject infoPanel;
    // Start is called before the first frame update
    // Update is called once per frame
    public void OnBtn()
    {
        infoPanel.SetActive(true);
    }
}
