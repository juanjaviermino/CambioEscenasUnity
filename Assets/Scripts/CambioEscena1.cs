using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena1 : MonoBehaviour
{
    public int escena;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(escena);
    }
}
