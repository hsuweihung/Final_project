using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    Rigidbody2D Person_Rigidbody2D;
    Vector2 moveDirection;
    //Animator CrogiDog_Animator;
    BoxCollider2D Person_boxCollider2D;
    // Update is called once per frame
    public int point = 0;
    public GameObject Correct;
    public GameObject Wrong;
    public GameObject Win;
    public GameObject Win_Button;
    public GameObject Continue_Button;
    public GameObject Win_icon;
    public GameObject Win_icon_Button;
    public float value;
    public float min;
    public float max;


    void Start()
    {
        Person_Rigidbody2D = GetComponent<Rigidbody2D>();
        Debug.Log("closed_win");
        Win_Button.SetActive(false);
        Debug.Log("closed_continue");
        Continue_Button.SetActive(false);
        Debug.Log("closed_icon");
        Win_icon.SetActive(false);
        Debug.Log("closed_icon_1");
        Win_icon_Button.SetActive(false);
    }
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("1");
        }*/
        if (Input.GetKey("right"))
        {
            Person_Rigidbody2D.velocity = new Vector2(2, 0);
        }
        else if (Input.GetKey("left"))
        {
            Person_Rigidbody2D.velocity = new Vector2(-2, 0);
        }
        else if (Input.GetKey("up"))
        {
            Person_Rigidbody2D.velocity = Vector2.up * 2;
        }
        else if (Input.GetKey("down"))
        {
            Person_Rigidbody2D.velocity = Vector2.down * 2;
        }
        if (Input.GetKeyUp("right") || Input.GetKeyUp("left") || Input.GetKeyUp("up") || Input.GetKeyUp("down"))
        {
            Person_Rigidbody2D.velocity = Vector2.zero;
        }
        Person_Rigidbody2D.position = new Vector2(Mathf.Clamp(Person_Rigidbody2D.position.x, -11.61888f, 8.752589f), Mathf.Clamp(Person_Rigidbody2D.position.y, -2.833496f, 6.768391f));
    }
    public void GetPoint()
    {
        point += 500;
        Debug.Log(point);
        if (point >= 2000) //過關判定
        {
            Debug.Log("open");
            Win.SetActive(true);
            Debug.Log("open_win");
            Win_Button.SetActive(true);
            Debug.Log("open_continue");
            Continue_Button.SetActive(true);
            Debug.Log("open_icon");
            Win_icon.SetActive(true);
            Debug.Log("open_icon_1");
            Win_icon_Button.SetActive(true);
            Correct.SetActive(false);
            Wrong.SetActive(false);
        }

    }

}