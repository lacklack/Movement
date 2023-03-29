using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Q3Movement;

public class Q3PlayerControllerEditModeTests {

    private GameObject playerGameObject;
    private Q3PlayerController playerController;

    [SetUp]
    public void Setup() {
        playerGameObject = new GameObject("Player");
        playerController = playerGameObject.AddComponent<Q3PlayerController>();
        //testInputProvider = Substitute();
        // playerController.InputProvider = testInputProvider;
        playerGameObject.AddComponent<CharacterController>();
    }

    [TearDown]
    public void Teardown() {
        Object.DestroyImmediate(playerGameObject);
    }

    
}