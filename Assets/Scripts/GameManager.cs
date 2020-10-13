using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer fondo;
    public GameObject columna;
    public float velocidad = 2;
    public List<GameObject> columnas;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 21 ; i++)
        {
            columnas.Add(Instantiate(columna, new Vector2(-10 + i, -3), Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.15f, 0) * Time.deltaTime;

        for (int i = 0; i < columnas.Count; i++)
        {
            if(columnas[i].transform.position.x <= -10)
            {
                columnas[i].transform.position = new Vector3(columnas[columnas.Count - 1].transform.position.x + 1 + i, -4, 0);
            }
            columnas[i].transform.position = columnas[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
        }
    }
}
