using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }
}
