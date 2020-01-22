using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    int contador ;
    Rigidbody rb;
    public Text puntuacion;
    public float velocidad;
    public Text win;
    public GameObject player;
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        actualizarmarcador();
        if (contador >= 10)
        {
            win.gameObject.SetActive(true);
            player.transform.position.Set(0,1,5);
        }
    }

    private void actualizarmarcador()
    {
        puntuacion.text = "Puntuacion: " + contador;
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        actualizarmarcador();
        win.gameObject.SetActive(false);
    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }
}
