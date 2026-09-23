using UnityEngine;
using TMPro;

public class trigger : MonoBehaviour
{
    [SerializeField] private GameObject Texto;
    private TextMeshProUGUI uiText;
    private int puntos = 0;
    public static int puntosFinal = 0;

    void Awake()
    {
        if (Texto != null)
        {
            uiText = Texto.GetComponent<TextMeshProUGUI>();
            if (uiText == null)
            {
                uiText = Texto.GetComponentInChildren<TextMeshProUGUI>();
            }
        }
        ActualizarTexto();
    }

    public void OnTriggerEnter(Collider other)
    {
        SumarPuntos();
    }

    void SumarPuntos()
    {
        puntos++;
        puntosFinal++;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        string texto = puntos.ToString();
        if (uiText != null)
        {
            uiText.text = texto;
        }
    }
}
            