using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float _speedR;
    void Update()
    {
        transform.Rotate(0, _speedR * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            GameController.Instance.Player.CurrentHealth += 1;
            gameObject.SetActive(false);
        }
    }
}
