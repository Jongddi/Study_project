using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    float swingSpeed = 0;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
		{
            this.swingSpeed = 20;
		}

        transform.Rotate(0, 0, swingSpeed);

        swingSpeed *= 0.98f;
    }
}
