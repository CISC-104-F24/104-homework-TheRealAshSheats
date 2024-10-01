using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
   // public bool foward_press = false;

    public int healthPoints = 100;
      public bool playerDead = false;
      public float moveSpeed = 3.5f;
      public string playerName = "Mario";

      public bool is_up_pressed;
      public bool is_down_pressed;

      public bool is_left_pressed;
      public bool is_right_pressed;

      public bool is_space_pressed;

      public int jump_stength;
    

      


      




    
        void Start()
    {
        //setting position 
       transform.position = new Vector3(0f,0f,0f);


      
       transform.position = transform.position + new Vector3 (0f,1f,0f);
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
      is_up_pressed = Input.GetKey(KeyCode.UpArrow);
      is_down_pressed = Input.GetKey(KeyCode.DownArrow);
      is_left_pressed = Input.GetKey(KeyCode.LeftArrow);
      is_right_pressed = Input.GetKey(KeyCode.RightArrow);
       is_space_pressed = Input.GetKeyDown(KeyCode.Space);
      

      if (is_up_pressed)
      {
        transform.position = transform.position + new Vector3 (1f,0f,0f) * moveSpeed * Time.deltaTime;
      }

      if (is_down_pressed)
      {
        transform.position = transform.position + new Vector3 (-1f,0f,0f) * moveSpeed * Time.deltaTime;
      }

      if (is_left_pressed)
      {
        transform.position = transform.position + new Vector3 (0f,0f,1f) * moveSpeed * Time.deltaTime;
      }

      if (is_right_pressed)
      {
        transform.position = transform.position + new Vector3 (0f,0f,-1f) * moveSpeed * Time.deltaTime;
      }

      if (is_space_pressed)
      {
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(new Vector3(0f,1f,0f) * jump_stength,ForceMode.Impulse);
      }

      




    }
}
//  Input.getKey(KeyCode key) is is currenty pressed
      // Imput.GetKeyDown(KeyCode key) was it just pressed this frame
      //Input.GetkeyUp(KeyCode.key) was it released this frame 
