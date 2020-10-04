using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public Camera ar_camera;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
    }

    void Update()
    {
        Transform obj_transform = GetComponent<Transform>();
        Debug.Log(Vector3.Distance(obj_transform.position, ar_camera.transform.position));
        if (Vector3.Distance(obj_transform.position, ar_camera.transform.position) < 900.0f)
        {
            anim.speed = 1;
        }
        else
        {
            anim.speed = 0;
        }
    }
}