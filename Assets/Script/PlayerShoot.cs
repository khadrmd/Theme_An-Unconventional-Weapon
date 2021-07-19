using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    public GameObject shootPoint;
    public GameObject player;
    public Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[0], new Vector2(shootPoint.transform.position.x, shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[1], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[2], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[3], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[4], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[5], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[6], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[7], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[8], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[9], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[10], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[11], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[12], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[13], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[14], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[15], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[16], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[17], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[18], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[19], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[20], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[21], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[22], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[23], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[24], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            AudioManager.PlayAudio("playerShoot");
            var clone = Instantiate(bulletPrefab[25], new Vector2(shootPoint.transform.position.x , shootPoint.transform.position.y), Quaternion.identity);
            clone.transform.localScale = new Vector2(player.transform.localScale.x, transform.localScale.y);
            Destroy(clone, 3f);
            StartCoroutine(Shooting());
        }
    }

    private IEnumerator Shooting()
    {
        animator.SetBool("Shooting",true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("Shooting", false);
    }


}
