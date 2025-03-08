using UnityEngine;

public class ShipShoot : MonoBehaviour
{
   
  InputSystem_Actions.PlayerActions controls;

  [SerializeField] int damage;
  [SerializeField] GameObject bullet;
    void Start()
    {
        controls=ControlsController.getControls();
    }
    void Shoot(){
        
    }
}
