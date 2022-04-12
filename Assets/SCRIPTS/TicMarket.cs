using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{
    //    El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de algunos productos que se encuentran en promoción

    //Se pide que se ingrese por inspector:
    //. Los nombre de tres productos
    //.Los precios de cada producto
    //.La cantidad de unidades deseada de cada producto

    //El programa debe cumplir los siguientes requerimientos:

    //Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

    //El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

    //El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.

    // Start is called before the first frame update
    public string nombreproducto1;
    public string nombreproducto2;
    public string nombreproducto3;
    public float precioproducto1;
    public float precioproducto2;
    public float precioproducto3;
    public int cantidadproducto1;
    public int cantidadproducto2;
    public int cantidadproducto3;
    void Start()
    {
        if (cantidadproducto1 < 1 || cantidadproducto2 < 1 || cantidadproducto3 < 1 || precioproducto1 < 1 || precioproducto2 < 1 || precioproducto3 < 1)
        {
            Debug.Log("El precio o la cantidad de productos es erronea, compruebe haber puesto 1 o mas.");
        }
        precioproducto1 = precioproducto1 * cantidadproducto1;
        precioproducto2 = precioproducto2 * cantidadproducto2;
        precioproducto3 = precioproducto3 * cantidadproducto3;
        float preciototalsindescuento;
        preciototalsindescuento = precioproducto1 + precioproducto2 + precioproducto3;
        if (cantidadproducto1 > 3)
        {
            precioproducto1 = precioproducto1 * 0.2f;
        }
        if (cantidadproducto2 > 3)
        {
            precioproducto2 = precioproducto2 * 0.2f;
        }
        if (cantidadproducto3 > 3)
        {
            precioproducto3 = precioproducto3 * 0.2f;
        }
        float preciototalcondescuento;
        preciototalcondescuento = precioproducto1 + precioproducto2 + precioproducto3;
        float descuentoefectuado;
        descuentoefectuado = preciototalsindescuento - preciototalcondescuento;
        Debug.Log("Monto total sin descuento: "+preciototalsindescuento+", Monto de los descuentos aplicados: "+descuentoefectuado+", Total con descuentos hechos: "+preciototalcondescuento+"");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
