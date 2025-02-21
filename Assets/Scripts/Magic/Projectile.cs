using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody rb;

    void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        DestroyProjectile(collision.contacts[0].point);
    }

    public void DestroyProjectile(Vector3 puntoColision)
    {
        //Cualquier logica que quieran correr al momento que el proyectil choca con la diana

        Destroy(gameObject);
    }

}
