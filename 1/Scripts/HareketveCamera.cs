using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketveCamera : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController characterController;
    public Transform camera;
    public float gorusNetligi;
    public float maxXrot;
    public float minXrot;
    public float curXrot;


   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Look();
    }

    void Move()

    {  
       float x = Input.GetAxisRaw("Horizontal");
       float y = Input.GetAxisRaw("Vertical");

       Vector3 dir = transform.right * x + transform.forward * y;
       dir.Normalize();
       dir *= moveSpeed * Time.deltaTime;
       characterController.Move(dir);


    }

    void Look()
    {
      float x = Input.GetAxis("Mouse X") * gorusNetligi;
      float y = Input.GetAxis("Mouse Y") * gorusNetligi;
     
      transform.eulerAngles += Vector3.up * x;

      curXrot += y;
      curXrot = Mathf.Clamp(curXrot , minXrot , maxXrot);
      camera.localEulerAngles = new Vector3 (-curXrot , 0.0f , 0.0f);
    }


}
