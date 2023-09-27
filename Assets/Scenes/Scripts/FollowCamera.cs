using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float cameraHeight = 10;

    // Update is called once per frame
    private void Update()
    {
        transform.position = target.position - transform.forward * cameraHeight;
    }
}
