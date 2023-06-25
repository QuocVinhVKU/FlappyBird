using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OngCong : MonoBehaviour
{
    public float speed = 1f;

    public Transform trans;

    private void Start()
    {
        Debug.Log(Time.deltaTime.ToString());
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.left * speed * Time.deltaTime;

        trans.position += Vector3.left * speed * Time.deltaTime;    
    }

}
