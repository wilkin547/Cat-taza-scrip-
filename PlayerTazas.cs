using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerTazas : MonoBehaviour
{
    private RectTransform transform;
    private Rigidbody2D rigidbody;
    private Animator animator;
    public Pulsado BotonDerecho;
    public Pulsado BotonIzquierdo;

    [SerializeField]
    public float Speed = 2;


    // Start is called before the first frame update
    private void Start()
    {
        transform = GetComponent<RectTransform>();
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        AnimationPlayer();
    }

    /// <summary>
    /// este metodo mueve al player de izquierda a derecha
    /// </summary>
    Vector2 Velozity = new Vector2();
    Vector2 Angule = new Vector2();
    float VelozidadHorizontal = 0;
    private void Movimiento()
    {
        

        if (BotonDerecho.Play)
        {
            VelozidadHorizontal = 1;
        }else if (BotonIzquierdo.Play)
        {
            VelozidadHorizontal = -1;
        }
        else
        {
            VelozidadHorizontal = 0;
        }

        //mueve el jugado en de izquierda a derecha
        Velozity.x = Speed * VelozidadHorizontal;


        //rota el personaje cuando se mueva
        rigidbody.velocity = Velozity;

        switch (VelozidadHorizontal)
        {
            case 1:
                Angule.y = 180;
                break;
            case -1:
                Angule.y = 0;
                break;
        }
        transform.localEulerAngles = Angule;


    }
    private void AnimationPlayer()
    {
        if (VelozidadHorizontal != 0)
        {
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }

    }
}
