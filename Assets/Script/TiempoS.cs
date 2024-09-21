    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TiempoS : MonoBehaviour
{
    // Start is called before the first frame update
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Tiempo;
    void Start()
    {
        contador_segundos =20;
        Tiempo.text = contador_segundos.ToString();

        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     IEnumerator corrutinaTiempo(){
        while (contador_segundos>=0){
            Tiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(1.00f);
    
        }
        Debug.Log("Se acabo el juego");
     }
}
