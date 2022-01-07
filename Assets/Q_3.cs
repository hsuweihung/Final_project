using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_3 : MonoBehaviour
{
    public GameObject introPanel;
    public GameObject PersonObj;
    public GameObject Correct;
    public GameObject Wrong;
    public GameObject Already;
    public int Q3_count = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    public void OnBtn()
    {
        introPanel.SetActive(false);
        Correct.SetActive(true);
        Q3_count += 1;
        Debug.Log("3");
        PersonObj.GetComponent<walk>().GetPoint();
    }

    void Update()
    {
        if (Q3_count >= 1)
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
            Debug.Log("2");
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
