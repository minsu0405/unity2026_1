using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] student = new int[5];

        student[0] = 100;
        student[1] = 90;
        student[2] = 70;
        student[3] = 50;
        student[4] = 80;

        for (int i = 0; i < 5; i++)
        Debug.Log("student"+ i +"ÀÇ Á¡¼ö" + student[i]);



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
