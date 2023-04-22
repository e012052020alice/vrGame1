using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem FireEffect;
    private RaycastHit RH;
    private AudioSource FireSound;
    // Start is called before the first frame update
    void Start()
    {
        FireSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void FireEvent()
    {
        if (Physics.Raycast(transform.position,transform.forward,out RH,100f))
        {
            FireEffect.transform.position = RH.point;
            FireEffect.transform.rotation = Quaternion.Euler(270, 0, 0);
            FireEffect.Stop();
            FireEffect.Play();
            FireSound.Play();
            if (RH.transform.tag == "enemy")
            {
                Destroy(RH.transform.gameObject);
            }
        }
    }
}
