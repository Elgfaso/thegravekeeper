using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{

    //Variables

    public float playerSpeed = 1.0f;
    public float playerRotation = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0.0f, 0.0f, vertical) * Time.deltaTime * playerSpeed);


        transform.Rotate(new Vector3(0.0f, horizontal,0.0f) * Time.deltaTime * playerRotation);

    
    }
}
