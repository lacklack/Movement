using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Q3Movement;

public class Q3PlayerControllerTests {
    private GameObject playerObject;
    private Q3PlayerController playerController;

    [SetUp]
    public void Setup() {
        playerObject = new GameObject();
        playerController = playerObject.AddComponent<Q3PlayerController>();
        playerObject.AddComponent<CharacterController>();
        playerController.Camera = new GameObject().AddComponent<Camera>();
    }

    [TearDown]
    public void Teardown() {
        Object.DestroyImmediate(playerObject);
    }

    // Add test methods here
}