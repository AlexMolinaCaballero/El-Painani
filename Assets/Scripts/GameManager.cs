using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer fondo;
    public GameObject columna;
    public float velocidad = 2;
    public GameObject piedra1;
    public GameObject piedra2;
    public bool gameOver = false;

    public List<GameObject> columnas;
    public List<GameObject> obstaculos;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 21 ; i++)
        {
            columnas.Add(Instantiate(columna, new Vector2(-10 + i, -3), Quaternion.identity));
        }
        obstaculos.Add(Instantiate(piedra1, new Vector2(14, -2), Quaternion.identity));
        obstaculos.Add(Instantiate(piedra2, new Vector2(18, -2), Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            CambiarEscena.LoadScene("GameOver");
        }
        if(gameOver == false)
        {
            fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.15f, 0) * Time.deltaTime;

            for (int i = 0; i < columnas.Count; i++)
            {
                if (columnas[i].transform.position.x <= -10)
                {
                    columnas[i].transform.position = new Vector3(columnas[columnas.Count - 1].transform.position.x + 1 + i, -3, 0);
                }
                columnas[i].transform.position = columnas[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
            }


            for (int i = 0; i < obstaculos.Count; i++)
            {
                if (columnas[i].transform.position.x <= -10)
                {
                    columnas[i].transform.position = new Vector3(-10, -2, 0);
                }
                obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
            }
        }
    }
}
