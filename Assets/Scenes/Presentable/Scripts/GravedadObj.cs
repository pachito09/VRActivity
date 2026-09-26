using UnityEngine;

public class GravedadObj : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private Vector3 posicionInicial;
    private Transform tm;
    private bool gravedadActiva = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tm = GetComponent<Transform>();
        posicionInicial = transform.position;
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    void Update()
    {
        if (transform.position.x != posicionInicial.x || transform.position.y != posicionInicial.y || transform.position.z != posicionInicial.z)
        {
            if (gravedadActiva == false)
            {
                rb.useGravity = false;
            }
            else if (gravedadActiva == true)
            {
                rb.useGravity = true;
                rb.constraints = RigidbodyConstraints.None;
            }
        }
    }
}
