using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform targetTF;
    public float x = 0;
    public float y = 18;
    public float z = -13;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - targetTF.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (y != 10)
            {
                y = 10;
                z = -10;
            } else
            {
                y = 18;
                z = -13;
            }

        }
        Vector3 newPos = targetTF.position + new Vector3(x, y, z);
        transform.position = newPos;
        //transform.position = targetTF.position + offset;
    }

}
