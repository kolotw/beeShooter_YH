using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //宣告區
    public float 速度 = 2f;
    public Transform 位置;
    public GameObject 子彈;
    public Transform 發射點A;
    public Transform 發射點B;
    // Start is called before the first frame update
    void Start()
    {
        //位置 = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // movement method
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.up * 速度 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.down * 速度 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * 速度 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * 速度 * Time.deltaTime);
            }
        }
        // set position
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.transform.position = 位置.transform.position;
        }
        // fire bullet
        if (Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            //Instantiate(遊戲物件, 發射點position, 旋轉角度);
            GameObject bb = Instantiate(子彈, 發射點A.position, Quaternion.identity);
            bb.GetComponent<Rigidbody>().AddForce(Vector3.up * 12000 * Time.deltaTime);
            Destroy(bb, 2f);

        }
    }
}
