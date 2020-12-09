using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciadorEsferas : MonoBehaviour
{
    //Variable para asociar esfera
    public GameObject Esfera;

    //Variable de posicion de la esfera
    Vector3 RandomPos;

    private float randomNumberz;
    private float randomNumberx;
    private float randomNumbery;

    // Start is called before the first frame update
    void Start()
    {
        for (int n = 1; n <= 15; n++)
        {
            CrearEsferas();
        }

        StartCoroutine("InstanciadorEsferas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearEsferas(float posZ = 0f)
    {
        randomNumberz = Random.Range(-10f, 10f);
        randomNumberx = Random.Range(-10f, 10f);
        randomNumbery = Random.Range(0f, 10f);
        RandomPos = new Vector3(randomNumberx, randomNumbery, randomNumberz);
       
        
        Instantiate(Esfera, RandomPos, Quaternion.identity);
    }

    IEnumerator InstanciadorEsferas()
    {
        //Bucle infinito (poner esto es lo mismo que while(true){}
        for (; ; )
        {

            CrearEsferas(0);         
          
            yield return new WaitForSeconds(1f);
        }
    }
}
