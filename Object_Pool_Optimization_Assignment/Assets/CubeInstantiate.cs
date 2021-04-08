using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiate : MonoBehaviour
{
    public GameObject cubePrefab;

    private void FixedUpdate()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity);
    }
}
