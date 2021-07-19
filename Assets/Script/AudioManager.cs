using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip bgm, playerJump, playerShoot, zombieSpawn, zombieHit, playerHit;
    static AudioSource audioSrc;

    private void Start()
    {
        bgm = Resources.Load<AudioClip>("bgm");
        playerJump = Resources.Load<AudioClip>("playerJump");
        playerShoot = Resources.Load<AudioClip>("playerShoot");
        zombieSpawn = Resources.Load<AudioClip>("zombieSpawn");
        zombieHit = Resources.Load<AudioClip>("zombieHit");
        playerHit = Resources.Load<AudioClip>("playerHit");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlayAudio(string clip)
    {
        switch (clip)
        {
            case "bgm":
                audioSrc.PlayOneShot(bgm);
                break;
            case "playerJump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "playerShoot":
                audioSrc.PlayOneShot(playerShoot);
                break;
            case "zombieSpawn":
                audioSrc.PlayOneShot(zombieSpawn);
                break;
            case "zombieHit":
                audioSrc.PlayOneShot(zombieHit);
                break;
            case "playerHit":
                audioSrc.PlayOneShot(playerHit, 1.5f);
                break;
        }
    }
}
