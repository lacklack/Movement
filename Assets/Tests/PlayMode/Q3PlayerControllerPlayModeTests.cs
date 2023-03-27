using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Q3Movement;

public class Q3PlayerControllerPlayModeTests {

    private GameObject playerGameObject;
    private Q3PlayerController playerController;
    private TestInputProvider testInputProvider;

    [SetUp]
    public void Setup() {
        playerGameObject = new GameObject("Player");
        playerGameObject.AddComponent<CharacterController>();
        playerController = playerGameObject.AddComponent<Q3PlayerController>();
        testInputProvider = new TestInputProvider();
        playerController.InputProvider = testInputProvider;
        var cameraGameObject = new GameObject("Camera");
        var cameraComponent = cameraGameObject.AddComponent<Camera>();
        cameraComponent.tag = "MainCamera"; // Make sure to tag the camera as the MainCamera
                                            // Create a ground object beneath the player
        GameObject groundObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
        playerGameObject.transform.position = new Vector3(0, 0.5f, 0);
        groundObject.transform.position = new Vector3(0, -0.5f, 0); // Adjust the position accordingly
    }

    [TearDown]
    public void Teardown() {
        Object.DestroyImmediate(playerGameObject);
    }

    [UnityTest]
    public IEnumerator Q3PlayerController_JumpTest() {
        yield return new WaitForSeconds(1.0f);
        // Set up the test input for jumping
        testInputProvider.JumpButtonDown = true;
        // Store the initial position
        Vector3 initialPosition = playerGameObject.transform.position;
        

        // Wait for a specific time (e.g., 0.5 seconds) to allow the jump to progress
        yield return new WaitForSeconds(1.0f);

        // Check if the player's position has changed positively in the y direction
        Vector3 finalPosition = playerGameObject.transform.position;
        Assert.Greater(finalPosition.y, initialPosition.y);
    }


}