using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimientoNave : MonoBehaviour
{
    //Variable velocidad nave
    private float moveSpeed = 3f;

    //Variable tiempo
    public Text textTiempo;

    private int tiempo;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ControlTiempo");

    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
    }

    void MoverNave()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");


        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * desplX);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * desplY);
        transform.Translate(Vector3.back * Time.deltaTime * 0 * 0);
    }

    IEnumerator ControlTiempo()
    {
        tiempo = 0;

        while (true)
        {
            tiempo += 1;

            textTiempo.text = "Tiempo: " + tiempo;



            yield return new WaitForSeconds(1f);
        }
        

    }



}
