using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Inventory;
using TopDownShooter.PlayerInput;

namespace TopDownShooter
{
    public class LocalPlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryController _inventoryController;
        [SerializeField] private InputData _shootInput;

        private void Update()
        {
            if (_shootInput.horizontalInput > 0)
            {
                _inventoryController.ReactiveShootCommand.Execute();
            }
        }

    }
}