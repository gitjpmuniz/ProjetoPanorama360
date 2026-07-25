using UnityEngine;

public class Hotspot : MonoBehaviour
{
    public PanoramaManager panoramaManager;
    public int panoramaDestino;

    void OnMouseDown()
    {
        panoramaManager.TrocarPanorama(panoramaDestino);
    }
}