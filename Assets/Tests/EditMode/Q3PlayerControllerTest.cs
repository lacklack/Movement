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

    [Test]
    public void MoveForward_WhenCalled_ChangesPlayerPosition() {
        // Arrange
        float initialZPosition = playerObject.transform.position.z;
        playerController.GroundSettings = new Q3PlayerController.MovementSettings(1, 1, 1);

        // Act
        playerController.m_MoveInput = new Vector3(0, 0, 1);
        playerController.GroundMove();

        // Assert
        float finalZPosition = playerObject.transform.position.z;
        Assert.Greater(finalZPosition, initialZPosition);
    }
}