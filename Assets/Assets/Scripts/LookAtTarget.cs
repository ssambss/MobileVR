using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform targetTurku;
    public Transform targetParis;
    public Transform targetCairo;
    public Transform targetRio;
    public Transform targetInca;

    public float damping = 1f;

    public GameObject turkuText;
    public GameObject parisText;
    public GameObject cairoText;
    public GameObject rioText;
    public GameObject incaText;


    void Start()
    {
        
    }

    void Update()
    {
        var turkuPos = targetTurku.position - transform.position;
        var parisPos = targetParis.position - transform.position;
        var cairoPos = targetCairo.position - transform.position;
        var rioPos = targetRio.position - transform.position;
        var incaPos = targetInca.position - transform.position;

        var turkuRotation = Quaternion.LookRotation(turkuPos);
        var parisRotation = Quaternion.LookRotation(parisPos);
        var cairoRotation = Quaternion.LookRotation(cairoPos);
        var rioRotation = Quaternion.LookRotation(rioPos);
        var incaRotation = Quaternion.LookRotation(incaPos);

        if (turkuText.activeInHierarchy)
            transform.rotation = Quaternion.Slerp(transform.rotation, turkuRotation, Time.deltaTime * damping);
        if (parisText.activeInHierarchy)
            transform.rotation = Quaternion.Slerp(transform.rotation, parisRotation, Time.deltaTime * damping);
        if (cairoText.activeInHierarchy)
            transform.rotation = Quaternion.Slerp(transform.rotation, cairoRotation, Time.deltaTime * damping);
        if (rioText.activeInHierarchy)
            transform.rotation = Quaternion.Slerp(transform.rotation, rioRotation, Time.deltaTime * damping);
        if (incaText.activeInHierarchy)
            transform.rotation = Quaternion.Slerp(transform.rotation, incaRotation, Time.deltaTime * damping);
    }
}
