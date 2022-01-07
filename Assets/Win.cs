using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Win_intro;
    public void OnBtn()
    {
        Debug.Log("UP");
        Win_intro.SetActive(false);
    }
}
