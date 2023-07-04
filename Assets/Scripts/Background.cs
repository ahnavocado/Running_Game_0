using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed=5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if(transform.position.x < -20){
        transform.position += new Vector3(40f,0,0);
        }
    }
}
