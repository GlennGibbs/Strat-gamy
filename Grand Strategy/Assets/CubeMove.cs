using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public int num;
    public Rigidbody rb;
    public Transform t;
    public List<GameObject> Tiles;
    // Start is called before the first frame update
    void Start()
    {
        t = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
    }

    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
