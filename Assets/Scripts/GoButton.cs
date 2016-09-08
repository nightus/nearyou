using UnityEngine;
using System.Collections;

public class GoButton : MonoBehaviour
{
    public static GoButton instance;
    public bool GuzikWcisniety = false;



    public void klikniecieGO()
    {
        GuzikWcisniety = true;
    }




    void Start()
    {
        instance = this;
    }






}
