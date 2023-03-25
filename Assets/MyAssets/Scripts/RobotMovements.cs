using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovements : MonoBehaviour
{
    [SerializeField] private List<GameObject> robots = new List<GameObject>();
    private List<Rigidbody> _rbList = new List<Rigidbody>();
    private int _forceIntensity = 2000;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var robot in robots)
        {
            _rbList.Add(robot.GetComponent<Rigidbody>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        MouvementRobot();
    }

    private void MouvementRobot()
    {
        foreach (var robot in robots)
        {
            if (robot.transform.position == new Vector3(102f, 11.3f, 1f) || robot.transform.position == new Vector3(111f, 11.3f, 1f))
            {
                foreach (var rb in _rbList)
                {
                    rb.AddForce(Vector3.forward * _forceIntensity);
                }
            }

            if (robot.transform.position == new Vector3(106f, 11.3f, 75f) || robot.transform.position == new Vector3(115f, 11.3f, 75f))
            {
                foreach (var rb in _rbList)
                {
                    rb.AddForce(Vector3.back * _forceIntensity);
                }
            }
        }
    }

}
