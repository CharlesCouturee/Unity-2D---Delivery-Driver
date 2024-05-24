using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // This thing position (camera) should be the same as the car's position
    [SerializeField] GameObject thingToFollow;

    void LateUpdate()
    {
        Vector3 offset = new Vector3(0f, 0f, -10f);
        Vector3 position = thingToFollow.transform.position + offset;
        transform.position = position;
    }
}
