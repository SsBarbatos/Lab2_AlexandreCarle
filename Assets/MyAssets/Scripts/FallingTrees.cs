using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class FallingTrees : MonoBehaviour
{
    private bool _isTrigger = false;
    [SerializeField] private List<GameObject> _traplist = new List<GameObject>();
    private List<Rigidbody> _rbList = new List<Rigidbody>();

    private void Start()
    {
        _isTrigger = false;

        // _rb1 = _trap1.GetComponent<Rigidbody>();

        foreach (var trap in _traplist)
        {
            _rbList.Add(trap.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && _isTrigger == false)
        {
            _isTrigger = true;

            // _rb1.useGravity = true;
            // _rb1.AddForce(Vector3.down * _forceIntensity);

            foreach (var rb in _rbList)
            {
                rb.useGravity = true;
            }
        }
    }
}
