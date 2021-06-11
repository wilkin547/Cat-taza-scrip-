using UnityEngine;

/// <summary>
/// mueve las tazitas del player dando la sensacion de que es mas grande 
/// </summary>
public class MoverTazita : MonoBehaviour
{
    [SerializeField]
    private GameObject tazita;
    private GameObject[] tazitas = new GameObject[41];
    // Start is called before the first frame update
    void Start()
    {
        //creating the tazas 
        for (int i = 0; i < tazitas.Length; i++)
        {
            tazitas[i] = Instantiate(tazita);
        }

        //set the posicion
        foreach (var item in tazitas)
        {
            item.transform.SetParent(transform);
            item.transform.position = tazita.transform.position;
            item.SetActive(false);
        }

        for (int i = 0,x = 1; i < tazitas.Length; x++, i++)
        {
            tazitas[i].transform.position = new Vector2(tazitas[i].transform.position.x, tazitas[i].transform.position.y + x * 0.1f);
        }
    }

    int i = 0;

    public void MoveTaza()
    {
        if (i > tazitas.Length)
        {
            return;
        }
        tazitas[i].SetActive(true);
        
        i++;


    }
}
