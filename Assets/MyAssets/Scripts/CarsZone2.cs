using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsZone2 : MonoBehaviour
{
    private bool isTrigger = false;
    [SerializeField] private List<GameObject> _traplist = new List<GameObject>();
    private List<Rigidbody> _rbList = new List<Rigidbody>();
    [SerializeField] private float _forceIntensity = 2000;

    void Start()
    {
        isTrigger = false;

        // _rb1 = _trap1.GetComponent<Rigidbody>();

        foreach (var trap in _traplist)
        {
            _rbList.Add(trap.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && isTrigger == false)
        {
            isTrigger = true;

            // _rb1.useGravity = true;
            // _rb1.AddForce(Vector3.down * _forceIntensity);

            foreach (var rb in _rbList)
            {
                rb.useGravity = true;

                rb.AddForce(Vector3.left * _forceIntensity);
            }
        }
    }
}
