using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private Rigidbody PlayerRigidBody;
    [SerializeField]
    private float movementSpeed = 10;
    private int count;
    public Text countText;
    public Text WinText;
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        PlayerRigidBody.AddForce(movement * movementSpeed);


    }
    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
       
    }
    private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            WinText.text = "You Win!!";

        }
    }
}
