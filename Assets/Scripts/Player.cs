using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
[SerializeField]
private float moveSpeed;
 
    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 moveTo =new Vector3(horizontalInput, verticalInput, 0f);
        transform.position += moveTo * moveSpeed *Time.deltaTime;
    }
}
