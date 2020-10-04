using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Creditos : MonoBehaviour
{
    public GameObject panelCreditos;
    // Start is called before the first frame update
    void Start()
    {
        panelCreditos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarCreditos()
    {
        if (panelCreditos.activeSelf == true)
        {
            DesactivarCreditos();
        }
        else
        {
            panelCreditos.SetActive(true);
        }
    }

    public void DesactivarCreditos()
    {
        panelCreditos.SetActive(false);
    }
}
