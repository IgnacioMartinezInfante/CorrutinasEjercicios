using System.Collections;
using UnityEngine;

public class Spawnaleatorio : MonoBehaviour
{
    public GameObject objetoPrefab;
    public float tiempoMinimo = 1f;
    public float tiempoMaximo = 3f;
    public Iniciojuego inicioJuego;

    void Start()
    {
        StartCoroutine(EsperarInicioJuego());
    }

    IEnumerator EsperarInicioJuego()
    {
        yield return StartCoroutine(inicioJuego.IniciarJuegoConContadorRegresivo());

        StartCoroutine(SpawnObjectRandomly());
    }

    IEnumerator SpawnObjectRandomly()
    {
        while (true)
        {
            Instantiate(objetoPrefab, transform.position, Quaternion.identity);
            float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);
            yield return new WaitForSeconds(tiempoEspera);
        }
    }
}
