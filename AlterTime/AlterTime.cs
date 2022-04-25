using System;
using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

namespace ModTemplate
{
    public class AlterTime : ModBehaviour
    {
        

        private void Awake()
        {
        }

        private void Start()
        {
            ModHelper.Console.WriteLine($"Outer Wilds - Speed up Time loaded.", MessageType.Success);
            };
        }

        [Obsolete]
        void Update()
        { 
            if (Keyboard.current[Key.Numpad0].wasReleasedThisFrame) 
            {
                Time.timeScale = 0;
            }
            if (Keyboard.current[Key.Numpad1].wasPressedThisFrame) 
            {
                Time.timeScale = 1;
            }
            if (Keyboard.current[Key.Numpad2].wasPressedThisFrame)
            {
                Time.timeScale = 2;
            }
            if (Keyboard.current[Key.Numpad3].wasPressedThisFrame)
            {
                Time.timeScale = 3;
            }
            if (Keyboard.current[Key.Numpad4].wasPressedThisFrame)
            {
                Time.timeScale = 4;
            }
            if (Keyboard.current[Key.Numpad5].wasPressedThisFrame)
            {
                Time.timeScale = 5;
            }
        }
    }
}
