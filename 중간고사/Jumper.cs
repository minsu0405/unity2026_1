using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    
     myRigidbody.AddForce(0, 5, 0);
        


    }
}
