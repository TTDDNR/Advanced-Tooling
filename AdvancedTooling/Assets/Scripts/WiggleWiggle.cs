using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiggleWiggle : MonoBehaviour
{
    [SerializeField]
    float time = 0;
    [SerializeField]
    int multi;
    // Start is called before the first frame update
    void Awake()
    {
        time = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.eulerAngles = new Vector3(Mathf.Sin(time) * multi, 0, Mathf.Cos(time) * multi);
        time += Time.deltaTime;
    }
}
