using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloworld : MonoBehaviour

    public int halth = 5;

    public int level = 1;

    public int speed = 1.2f;
{
    void Start()
    {
        halth = halth + level
        print("Helth" + halth)
    }

    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition
    }
}
