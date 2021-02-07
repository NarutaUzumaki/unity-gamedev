using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 Direction;
    public float MaxDistance = 5;

    private float _sign = 1;

    private void Update()
    {
        gameObject.transform.position += _sign * Direction * Time.deltaTime;
        if (MaxDistance <= gameObject.transform.position.magnitude)
        {
            _sign *= -1;
            gameObject.transform.Rotate(0, 0, 90*2);
        }
    }

}
