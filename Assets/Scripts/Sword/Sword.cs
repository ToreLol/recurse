using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject marker; //Este prefab sera instanciado en el punto donde golpee la espada al enemigo, pueden usarlo para instanciar particulas
    public bool canCollide = false;

    [HideInInspector]
    public Rigidbody rb;

    public float velocity; //La velocidad actual de la espada, puede servir para manipular parametros del Shader
    private Vector3 previousPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        previousPoint = transform.position;
    }

    void Update()
    {
        velocity = (transform.position - previousPoint).magnitude / Time.deltaTime;
        previousPoint = transform.position;
    }

    void FixedUpdate()
    {
        velocity = rb.linearVelocity.magnitude;
    }

    void OnTriggerEnter(Collider other)
    {
        if(canCollide == true)
        {
            Instantiate(marker,other.ClosestPoint(transform.position), Quaternion.identity);
            canCollide = false;
        }
    }
}
