﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myles
{
    [RequireComponent(typeof(ChangeRoom))]
    public class Door2 : MonoBehaviour
    {
        void OnMouseDown()
        {
            if (Inventory.main.HasItem(Item.Paper))
            {
                GetComponent<ChangeRoom>().GotoNextRoom();
                
            }
        }
    }
}
