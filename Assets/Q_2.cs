using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_2 : MonoBehaviour

{
    public GameObject introPanel;
    public GameObject PersonObj;
    public GameObject Correct;
    public GameObject Wrong;
    public GameObject Already;
    public int Q2_count = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    public void OnBtn()
    {
        introPanel.SetActive(false);
        Correct.SetActive(true);
        Debug.Log("2");
        Q2_count += 1;
        PersonObj.GetComponent<walk>().GetPoint();
    }
    void Update()
    {
        if (Q2_count >= 1)
        {
            Debug.Log("already");
            introPanel.SetActive(false);
            Already.SetActive(true);

        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Person")
        {
            introPanel.SetActive(true);
            Debug.Log("1");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Person")
        {
            introPanel.SetActive(false);
            Correct.SetActive(false);
            Wrong.SetActive(false);
            Already.SetActive(false);
        }

    }
    /*void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            introPanel.SetActive(false);
            Correct.SetActive(false);
            Wrong.SetActive(false);
        }
    }*/
}
