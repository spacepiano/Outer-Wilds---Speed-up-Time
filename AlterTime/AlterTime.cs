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
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {


            // Starting here, you'll have access to OWML's mod helper.

            ModHelper.Console.WriteLine($"My mod {nameof(ModTemplate)} is loaded!", MessageType.Success);
            


            // Example of accessing game code.
            LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
            {
                if (loadScene != OWScene.SolarSystem) return;
                var playerBody = FindObjectOfType<PlayerBody>();
                ModHelper.Console.WriteLine($"Found player body, and it's called {playerBody.name}!",
                    MessageType.Success);


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
            if (Keyboard.current[Key.Numpad4].wasPressedThisFrame)
            {
                Time.timeScale = 5;
            }
        }
    }
}
