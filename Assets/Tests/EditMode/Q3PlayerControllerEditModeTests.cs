using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Q3Movement;

public class Q3PlayerControllerEditModeTests {

    private GameObject playerGameObject;
    private Q3PlayerController playerController;
    private TestInputProvider testInputProvider;

    [SetUp]
    public void Setup() {
        playerGameObject = new GameObject("Player");
        playerController = playerGameObject.AddComponent<Q3PlayerController>();
        testInputProvider = new TestInputProvider();
        playerController.InputProvider = testInputProvider;
        playerGameObject.AddComponent<CharacterController>();
    }

    [TearDown]
    public void Teardown() {
        Object.DestroyImmediate(playerGameObject);
    }

    
}