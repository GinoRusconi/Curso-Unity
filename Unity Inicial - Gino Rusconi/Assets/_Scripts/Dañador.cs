using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañador : MonoBehaviour
{
    public int _Daño;
    public string _TagTarget;
    public GameObject sfxSound;
    public AudioClip impactBullet;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Vida>())
        {
            if (other.tag == _TagTarget || other.tag == "Wall")
            {
                Vida vida = other.gameObject.GetComponent<Vida>();
                vida.GetDamage(_Daño);
                GameObject bulletParticle = Instantiate(sfxSound, gameObject.transform.position, gameObject.transform.rotation);
                if (bulletParticle.GetComponent<AudioSource>().clip != impactBullet)
                {
                    bulletParticle.GetComponent<AudioSource>().clip = impactBullet;
                    bulletParticle.GetComponent<AudioSource>().Play();
                }else
                {
                    bulletParticle.GetComponent<AudioSource>().Play();
                }
                
                Destroy(bulletParticle,impactBullet.length);
                Destroy(gameObject);
            }
        }
    }
}
