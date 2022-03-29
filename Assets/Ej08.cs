using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error &quot;El día ingresado no es válido&quot;.

public class Ej08 : MonoBehaviour
{

	public int dia;
	
    // Start is called before the first frame update
    void Start()
    {
		switch (dia)
		{
			case 1:
				Debug.Log("Es Domingo");
				break;
			case 2:
				Debug.Log("Es Lunes");
				break;
			case 3:
				Debug.Log("Es Martes");
				break;
			case 4:
				Debug.Log("Es Miercoles");
				break;
			case 5:
				Debug.Log("Es Jueves");
				break;
			case 6:
				Debug.Log("Es viernes");
				break;
			case 7:
				Debug.Log("Es Sábado");
				break;
			default:
				Debug.Log("El día ingresado no es válido");
				break;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
