using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length < 10 && length > -10)
        {
            this.distance.GetComponent<Text>().text = "점수 : 1점";
            if (length < 5 && length > -5)
			{
                this.distance.GetComponent<Text>().text = "점수 : 5점";
                if (length < 1 && length > -1)
				{
                    this.distance.GetComponent<Text>().text = "점수 : 10점";
                }
            }
        }
        else
            this.distance.GetComponent<Text>().text = "점수 : ";
    }
}
