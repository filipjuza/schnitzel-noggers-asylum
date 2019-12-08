using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    private float minRotation = 250f;
    private float maxRotation = 290f;
    private bool inFinalPosition = false;
    private bool attached = false;
    private Rigidbody keyRigidbody;

    private void Start()
    {
        keyRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (attached)
        {
            if (inFinalPosition)
            {
                transform.eulerAngles = new Vector3(270, 180, 0);
                keyRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            } else
            {
                var rotation = transform.rotation.eulerAngles.x;

                if (rotation >= minRotation && rotation <= maxRotation)
                {
                    inFinalPosition = true;
                    Debug.Log("Waduhek you win.");
                }
            }
        }
    }

    public void onKeyAttached()
    {
        attached = true;
        keyRigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }
}
