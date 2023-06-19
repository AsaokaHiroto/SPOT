using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private Animation anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gemeObject.CompareTag("neko"))
        {
            anim.SetBool("yarare", true);
        }
    }
}
