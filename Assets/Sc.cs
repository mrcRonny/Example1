using UnityEngine;
using Mirror;

public class Example : NetworkBehaviour
{

    private void Update()
    {
        if (isLocalPlayer)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 playerMovement = new Vector3(h / 20, v / 20, 0);
            transform.position = transform.position + playerMovement;
        }
    }
}

