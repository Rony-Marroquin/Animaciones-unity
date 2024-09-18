using UnityEngine;

public class NPC : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();

        
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    void Update()
    {
      
    }
}
