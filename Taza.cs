using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Taza : Moviment
{
    
    
    private RectTransform transform;
    protected override void Setvelocity()
    {
        if (!GameControlerTazas.gameControler.GetBoolFail())
        {
            rigidbody2D.velocity = GameControlerTazas.gameControler.SetVelocity();
        }
        else
        {
            rigidbody2D.simulated = false;
        }
       
    }

    protected override void Start()
    {
        base.Start();
        transform = GetComponent<RectTransform>();
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ReStar();
            GameControlerTazas.gameControler.UpdateScore();
            GameControlerTazas.gameControler.tazita.MoveTaza();
            return;
            
        }
        if (collision.transform.CompareTag("Finish"))
        {
            ReStar();
            GameControlerTazas.gameControler.GameOver();
            return;
        }
        

            
        
        
    }

    protected override void ReStar()
    {
        transform.position = GameControlerTazas.gameControler.posicionesIniciales[Random.Range(0, GameControlerTazas.gameControler.posicionesIniciales.Length -1)].position;
        gameObject.SetActive(false);
    }
}
