using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _vitesse = 500f;
    private Rigidbody _rb;

    // méthodes privées
    private void Start()
    {
        // définir la position initiale
        // 'f' pour float
        transform.position = new Vector3(23.45f, 10.287f, 79.08f);

        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementJoueur();
    }

    private void MouvementJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        // Empeche le vecteur de depasser 1 pour la direction
        direction.Normalize();

        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    public void EndGamePlayer()
    {
        this.gameObject.SetActive(false);
    }
}
