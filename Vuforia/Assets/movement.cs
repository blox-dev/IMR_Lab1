using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    private Transform cubeTransform;
    private float zPos = 0f;

    void Start()
    {
        cubeTransform = cube.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeTransform.position = new Vector3(0.009f, 0.119f, zPos);
        zPos += 0.01f;
    }
}
