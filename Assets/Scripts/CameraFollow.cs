using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Essa classe é utilizada para que a câmera acompanhe o personagem principal e também permaneça nos limites da cena
public class CameraFollow : MonoBehaviour
{
    public float speed = 0.15f;
    private Transform target;

    public bool maxMin;
    public float xMin;
    public float yMin;
    public float xMax;
    public float yMax;
    void Start()
    {
        // Seta o player como Alvo para acompanhar
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (target)
        {
            // seta posição inicial da câmera em cena
            transform.position = Vector3.Lerp(transform.position, target.position, speed) + new Vector3(0, 0, -10);

            if (maxMin)
            {
                // Trava a câmera nos pontos definidos como minimos e máximos.
                transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax), -10);

            }

        }
    }
}
