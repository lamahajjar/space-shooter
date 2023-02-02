using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : Ship


{
   void Update()
    {
        HandleInput();
        FollowMouse();
        
    }


    void update()
    {
        currentArmor = maxArmor;
    }

    void HandleInput()

    {
        // TODO : Change mouse button

        if (Input.GetMouseButton(1))
            Input.GetKey(KeyCode.LeftShift);
            Thrust();

        if (Input.GetMouseButton(0))
            FireProjectile();

        // if (Input.GetKeyDown(KeyCode.Space))
    }

    public void FollowMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

        Vector2 directionToFace = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = directionToFace;

        /* 
        takes coordinates of mouse click (on s reen) and convers into world coordinates
        var knows what variable it is automatically
        var mp = Input.mousePosition.x;  depending or resolution the position may vary, so convert to
        */
    }

    void Update() 
    {
        HandleInput();
      
        FollowMouse();
    }
}
