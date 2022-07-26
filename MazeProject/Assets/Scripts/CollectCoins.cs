using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    // Start is called before the first frame update

    private void Update()
    {
        transform.Rotate(0f, 0f, 100*Time.deltaTime, Space.Self);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<PlayerMovement>(out var playerMovement))
        {
            playerMovement.wallet += 1;
            Debug.Log($"Wallet coins{playerMovement.wallet}");
            Destroy(gameObject);
        }
    }
}
