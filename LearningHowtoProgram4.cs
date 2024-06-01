using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgam4 : MonoBehaviour
{
    private void Start()
    {
        float health = 100;

        if (health <= 0)
        {
            Debug.Log("Anda mati");
        }else if (health < 50)
        {
            Debug.Log("Darah kurang dari setengah");
        }else
        {
            Debug.Log("Nyawa cukup, gas serang monster lagi!");
        }

        switch (health) {

            case 100:
                Debug.Log("Darah 100");
                break;

            case 50:
                Debug.Log("Darah 50");
                break;

            case 0:
                Debug.Log("Darah 0");
                break;

            default:
                Debug.Log("Darah lebih dari 100!");
                break;
        }

        //if (health <10 || health < 20)
        //{
        //    Debug.Log("Butuh darah lebih banyak");
        //}

    }   
}
