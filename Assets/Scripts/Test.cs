using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake được gọi");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable được gọi");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable được gọi");
    }
    private void OnDestroy()
    {
        Debug.Log("Destroy được gọi");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start được gọi");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update được gọi");
    }
}
