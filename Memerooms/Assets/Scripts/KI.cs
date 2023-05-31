using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KI : MonoBehaviour
{
    [SerializeField] GameObject goPlayer;


    [SerializeField] int iChancePercent;

    [SerializeField] AudioClip[] clips;

    public bool bFollow;

    private AudioSource audioS;

    private float fTime = 0;

    private NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (bFollow)
        {
            nav.SetDestination(goPlayer.transform.position);
        }

        int i = Random.Range(0, 100);

        if (i <= iChancePercent) 
        {
            if (!audioS.isPlaying)
            {
                int j = Random.Range(0, clips.Length);

                audioS.clip = clips[j];

                audioS.Play();
            }

        }

        if (audioS.isPlaying)
        {
            fTime += Time.deltaTime;

            if (fTime >= 1.4f)
            {
                audioS.Stop();
                fTime = 0;
            }
        }
    }
}
