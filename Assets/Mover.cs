using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float yValue = 0;
    [SerializeField]float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Time.deltaTime); 
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue, yValue, zvalue);
    }
}
