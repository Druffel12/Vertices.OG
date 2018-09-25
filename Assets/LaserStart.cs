using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserStart : MonoBehaviour
{
    public Animator anim;
    public GameObject LaserEffects;
	
    public void Laser()
    {
        anim.SetTrigger("ButtonPushed");
        GameObject Lazar = Instantiate(LaserEffects);
        Destroy(Lazar, 6f);
        
    }
    //IEnumerator EndLaser(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    Destroy(Lazar);
    //    StopAllCoroutines();
    //    yield break;
        
    //}
    ////void End()
    ////{
    ////    StopCoroutine(EndLaser(0.5f));
    ////}
}
