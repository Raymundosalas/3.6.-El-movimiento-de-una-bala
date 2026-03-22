using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;      // Velocidad de la bala
    public float lifeTime = 3f;    // Tiempo antes de destruirse
    public float damage = 1f;      // Daño (opcional)

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; // Movimiento en dirección del disparo

        Destroy(gameObject, lifeTime); // Destruye la bala después de cierto tiempo
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Aquí puedes agregar lógica de daño si es necesario
        Destroy(gameObject);
    }
}
