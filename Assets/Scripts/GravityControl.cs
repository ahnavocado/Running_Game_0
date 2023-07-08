using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R)){
        Physics2D.gravity = new Vector2(9.8f,0);
        }
    }
}
