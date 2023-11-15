using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Iniciojuego : MonoBehaviour
{
    public Text contadorRegresivo;
    public float tiempoCuentaRegresiva = 3f;

    void Start()
    {
        StartCoroutine(IniciarJuegoConContadorRegresivo());
    }

    public IEnumerator IniciarJuegoConContadorRegresivo()
    {
        int tiempo = Mathf.CeilToInt(tiempoCuentaRegresiva);

        while (tiempo > 0)
        {
            contadorRegresivo.text = tiempo.ToString();
            yield return new WaitForSeconds(1f);
            tiempo--;
        }

        contadorRegresivo.text = "¡Comienza el juego!";
        yield return new WaitForSeconds(1f);
        contadorRegresivo.gameObject.SetActive(false);
    }
}
