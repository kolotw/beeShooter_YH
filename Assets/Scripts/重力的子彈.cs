using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 重力的子彈 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 12000 * Time.deltaTime);
        }
    }
}
