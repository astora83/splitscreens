using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPCameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
    }
}
