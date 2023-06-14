using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // 实例化Prefab
        // GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0:left 1:right
        {
            // 实例化Prefab
            GameObject bullet =  GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            // rd.AddForce(Vector3.forward); // 施加力
            rd.velocity = Vector3.forward * 30; // 设置速度
        }
    }
}
