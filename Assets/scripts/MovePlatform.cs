using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour
{
    public float Max_Y = 60, //Максимальная высота
                 Min_Y = 50;
    public int
                SpeedMove = 0,  //скорость движения лифта
                VectorMove = 1; //направление движения
                                // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //получим текущую позицию лифта
        Vector3 P = this.transform.position;
        //задаем движение относительно оси Y
        P.y = P.y + SpeedMove * VectorMove * Time.deltaTime;
        //меняем координаты лифта на новые 
        this.transform.position = P;
        if (P.y > Min_Y) //проверяем максимальную высоту
        {
            VectorMove = -1;
            this.transform.position = P;//
        }

            if (P.y < Max_Y) //проверяем минимальную высоту
            {
                VectorMove = 1;

                this.transform.position = P;//
            }
        
    }
}