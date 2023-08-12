using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMove : MonoBehaviour
{
    public Transform player; //Сюда пихать своего персонажа
    float startPointx;
    float startPointy;

    float startRotx;
    float startRoty;

    float currPointx;
    float currPointy;

    float currRotx;
    float currRoty;
    public float speed;
    public Vector2 direction;


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //В момент нажатия ЛКМ
        {
            startPointx = Input.mousePosition.x; //Мы задаем начальную точку
            startPointy = Input.mousePosition.y;

            startRotx = player.rotation.eulerAngles.y;
            startRoty = player.rotation.eulerAngles.x; //И считываем начальный поворот игрока, чтобы вращать относительно него
        }
            currPointx = Input.mousePosition.x;
            currPointy = Input.mousePosition.y; //Мы задаем конечную точку
            float swipeLength = currPointx - startPointx; //Узнаем расстояние между начальной и конечной точкой

            currRotx = startRotx + swipeLength / 2;
            currRoty = startRoty + swipeLength / 2; //И задаем новый поворот. 2 - это коэффициент чувствительности. Его подбирай сам
            player.rotation = Quaternion.Euler(player.rotation.eulerAngles.x, currRotx, player.rotation.eulerAngles.z);
            player.rotation = Quaternion.Euler(player.rotation.eulerAngles.y, currRoty, player.rotation.eulerAngles.z); //Применяем новый поворот на игрока
        
        transform.Translate(speed*direction);
    }


    private void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
    }
}
