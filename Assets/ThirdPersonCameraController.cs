using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float Height = 15f;
    public float Distance = 50f;
    public GameObject FollowObject;
    private Quaternion _startingRotation = Quaternion.identity;
    // Start is called before the first frame update
    private void UpdateCameraPosition()
    {
        Vector3 startingRotation = transform.eulerAngles;
        Vector3 target = FollowObject.transform.position;
        
        // Get the height right
        target.y += Height;

        // Get the distance right

        // Make sure we reset out rotation
    }
    
    void Start()
    {
        UpdateCameraPosition();
        _startingRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(FollowObject == null) return;

        UpdateCameraPosition();
        transform.rotation = _startingRotation;
    }
}
