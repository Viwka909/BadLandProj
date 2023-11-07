using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerDependencies;
public class InputListner : MonoBehaviour
{
    [SerializeField] GameObject playerObject;
    Movement playerMovement;
    void Start()
    {
      playerMovement  = playerObject.GetComponent<Movement>();
    }
    void Update()
    {
        playerMovement.movement.x = Input.GetAxisRaw("Horizontal");//hash
        if (Input.GetKey(KeyCode.Space))
        {
            playerMovement.jumpPressed = true;
        }
        else
        {
             playerMovement.jumpPressed = false;
        }
    }
}
