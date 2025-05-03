using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(0, 1, 0);
    }
}
