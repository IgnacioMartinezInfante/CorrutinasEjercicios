using System.Collections;
using UnityEngine;

public class Spawnfijo : MonoBehaviour
{
    public GameObject objetoPrefab;
    public float intervaloSpawn = 2f;
    public Iniciojuego inicioJuego;

    void Start()
    {
        StartCoroutine(EsperarInicioJuego());
    }

    IEnumerator EsperarInicioJuego()
    {
        yield return StartCoroutine(inicioJuego.IniciarJuegoConContadorRegresivo());

        StartCoroutine(SpawnObjectRegularly());
    }

    IEnumerator SpawnObjectRegularly()
    {
        while (true)
        {
            Instantiate(objetoPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(intervaloSpawn);
        }
    }
}
