using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    public float turnspeed;
    private float horizontalinput;
    private float verticalinput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //Quiero el eje horizontal
        horizontalinput =Input.GetAxis("Horizontal");
        verticalinput =Input.GetAxis("Vertical");
        //Time.deltaTime para que se pueda ver bien en compus diferentes 
        
        transform.Translate(Vector3.forward*velocidad*Time.deltaTime*verticalinput);
        transform.Rotate(Vector3.up,turnspeed*Time.deltaTime*horizontalinput );

    }
}
