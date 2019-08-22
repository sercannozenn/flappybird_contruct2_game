using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusScript : MonoBehaviour
{
    public float hiz;
    public float ziplamaGucu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * hiz);

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu * Time.deltaTime);
        }
    }
}
