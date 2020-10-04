using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Ajustes : MonoBehaviour
{
    public GameObject panelAjustes;
    // Start is called before the first frame update
    void Start()
    {
        panelAjustes.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarAjustes()
    {
        if (panelAjustes.activeSelf == true)
        {
            DesactivarAjustes();
        }
        else
        {
            panelAjustes.SetActive(true);
        }
    }

    public void DesactivarAjustes()
    {
        panelAjustes.SetActive(false);
    }
}
