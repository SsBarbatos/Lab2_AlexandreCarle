using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private bool _isTrigger;
    [SerializeField] private List<GameObject> pressurePlate = new List<GameObject>();
    [SerializeField] private List<GameObject> electricDoor = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        _isTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && _isTrigger == false)
        {
            foreach (var plate in pressurePlate)
            {
                plate.GetComponent<MeshRenderer>().material.color = Color.green;
            }

            foreach (var door in electricDoor)
            {
                door.transform.position = new Vector3(0f, 0f, 0f);
            }

            _isTrigger = true;
        }
    }
}
