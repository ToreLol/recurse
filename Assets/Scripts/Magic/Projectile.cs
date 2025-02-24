using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class Projectile : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody rb;
    public VisualEffect hitEffect;

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
        VisualEffect vfxInstance = Instantiate(hitEffect, puntoColision, Quaternion.identity);
        vfxInstance.Play(); // Reproduce el efecto
        Destroy(vfxInstance.gameObject, 2f);
        Destroy(gameObject);
    }

}
