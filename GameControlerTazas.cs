using UnityEngine;
using System.Collections.Generic;

public class GameControlerTazas : gameControllerPadre
{
    public static GameControlerTazas gameControler;
    public GameObject[] taza = new GameObject[3];
    /// <summary>
    /// utiliza estas posicion para reiniciar las posiciones de las tazas 
    /// </summary>
    public RectTransform[] posicionesIniciales = new RectTransform[5];
    public MoverTazita tazita;
    void Start()
    {
        GameControlerTazas.gameControler = this;
        InvokeRepeating(nameof(ActiveTaza), timeWait,0.3f);
        
    }
    
    /// <summary>
    /// instacia a taza
    /// </summary>
    public void ActiveTaza()
    {
        if (!gameControler.GetBoolFail())
        {
            taza[Random.Range(0, taza.Length - 1)].SetActive(true);
        }
       
    }

    [SerializeField]
    private readonly float timeWait;
   

}
