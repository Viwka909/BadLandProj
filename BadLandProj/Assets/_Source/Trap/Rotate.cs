using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] GameObject trap;
    [SerializeField] float spinSpeed;

    private float time;
    void Update()
    {
        time += Time.fixedDeltaTime;
        trap.transform.rotation = Quaternion.Euler(0, 0, time * spinSpeed);
    }
}
