using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharctorMove : MonoBehaviour
{
    public float spd = 5f;

    bool flagLeftWall = false;

    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        if(flagLeftWall && h < -0.9f)
        {
            h = 0;
        }

        float v = Input.GetAxis("Vertical");


        //transform.Translate(Vector3.right * 5 *Time.deltaTime);
        Vector3 direct = new Vector3(h, v, 0);

        transform.position = transform.position + direct * spd * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "LeftWall")
        {
            flagLeftWall = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "LeftWall")
        {
            flagLeftWall = false;
        }
    }
}
