using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //�ŧi��
    public float �t�� = 2f;
    public Transform ��m;
    public GameObject �l�u;
    public Transform �o�g�IA;
    public Transform �o�g�IB;
    // Start is called before the first frame update
    void Start()
    {
        //��m = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // movement method
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.up * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.down * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * �t�� * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * �t�� * Time.deltaTime);
            }
        }
        // set position
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.transform.position = ��m.transform.position;
        }
        // fire bullet
        if (Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            //Instantiate(�C������, �o�g�Iposition, ���ਤ��);
            GameObject bb = Instantiate(�l�u, �o�g�IA.position, Quaternion.identity);
            bb.GetComponent<Rigidbody>().AddForce(Vector3.up * 12000 * Time.deltaTime);
            Destroy(bb, 2f);

        }
    }
}
