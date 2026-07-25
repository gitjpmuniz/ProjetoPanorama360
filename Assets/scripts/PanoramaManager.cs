using UnityEngine;

public class PanoramaManager : MonoBehaviour
{
    [Header("Esfera que exibe o panorama")]
    public Renderer panoramaRenderer;

    [Header("Materiais dos panoramas")]
    public Material[] panoramas;

    private int panoramaAtual = 0;

    void Start()
    {
        panoramaRenderer.material = panoramas[panoramaAtual];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ProximoPanorama();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PanoramaAnterior();
        }
    }

    void ProximoPanorama()
    {
        panoramaAtual++;

        if (panoramaAtual >= panoramas.Length)
            panoramaAtual = 0;

        panoramaRenderer.material = panoramas[panoramaAtual];
    }

    void PanoramaAnterior()
    {
        panoramaAtual--;

        if (panoramaAtual < 0)
            panoramaAtual = panoramas.Length - 1;

        panoramaRenderer.material = panoramas[panoramaAtual];
    }




    public void TrocarPanorama(int indice)
{
    if (indice >= 0 && indice < panoramas.Length)
    {
        panoramaAtual = indice;
        panoramaRenderer.material = panoramas[panoramaAtual];
    }
}
}