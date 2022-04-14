using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Doorway : MonoBehaviour
{
    private BoxCollider _bounds;
    
    [TagSelector]
    public string AllowedTag;
    public GameObject DoorExit;

    void Start()
    {
        _bounds = GetComponent<BoxCollider>();
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider == null) return;
        if(DoorExit == null) return;
        if(collider.gameObject.tag != AllowedTag) return;

        print(collider?.gameObject?.name);
        collider.gameObject.transform.position = DoorExit.transform.position;
    }
}
