using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHot : MonoBehaviour
{
     
    public bool Hot = false;
    public bool done = false;
    public Material fire;
    private MeshRenderer knife;
    // Start is called before the first frame update
    void Start()
    {
        knife = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if (Hot && !done)
        {
            knife.material = fire;
            done = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (Hot && collision.collider.gameObject.tag == "destroy")
        {
            Debug.Log("colliding");
            Destroy(collision.collider.gameObject);

        }

    }
}
