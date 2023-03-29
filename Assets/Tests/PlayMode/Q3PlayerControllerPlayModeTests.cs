using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using NUnit;
using System.Collections;
using Q3Movement;
using NSubstitute;

public class Q3PlayerControllerPlayModeTests {

    private GameObject playerGameObject;
    private Q3PlayerController playerController;

    [SetUp]
    public void Setup() {
        playerGameObject = new GameObject("Player");
        playerGameObject.AddComponent<CharacterController>();
        playerController = playerGameObject.AddComponent<Q3PlayerController>();
        var testInputProvider = Substitute.For<IInputProvider>();
        playerController.InputProvider = testInputProvider;
        var cameraGameObject = new GameObject("Camera");
        var cameraComponent = cameraGameObject.AddComponent<Camera>();
        cameraComponent.tag = "MainCamera";
        //GameObject groundObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
        //groundObject.transform.position = new Vector3(0, 0.0f, 0);
        playerGameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    [TearDown]
    public void Teardown() {
        Object.DestroyImmediate(playerGameObject);
    }

    /*
    [UnityTest]
    public IEnumerator Q3PlayerController_JumpTest() {
        Vector3 initialPosition = playerGameObject.transform.position;
        playerController.InputProvider.GetJumpButtonDown().Returns(true);
        playerController.InputProvider.GetDesltaTime().Returns(5);
        yield return new WaitForSeconds(5);

        // Check if the player's position has changed positively in the y direction
        Vector3 finalPosition = playerGameObject.transform.position;
        Debug.Log("Final:" + finalPosition + " Start pos:" + initialPosition);
        Assert.Greater(finalPosition.y, initialPosition.y);
    }
    */

    [UnityTest]
    public IEnumerator Q3PlayerController_MoveRightTest() {
        Vector3 initialPosition = playerGameObject.transform.position;
        playerController.InputProvider.GetMovementInput().Returns(new Vector2(1.0f, 0.0f));
        playerController.InputProvider.GetDeltaTime().Returns(0.0167f);

        yield return null;
        yield return null;

        // Check if the player's position has changed positively in the y direction
        Vector3 finalPosition = playerGameObject.transform.position;
        Debug.Log("Final:" + finalPosition + " Start pos:" + initialPosition);
        Assert.Greater(finalPosition.x, initialPosition.x);
    }

    [UnityTest]
    public IEnumerator Q3PlayerController_MoveLeftTest() {
        Vector3 initialPosition = playerGameObject.transform.position;
        playerController.InputProvider.GetMovementInput().Returns(new Vector2(-1.0f, 0.0f));
        playerController.InputProvider.GetDeltaTime().Returns(0.0167f);

        yield return null;
        yield return null;

        // Check if the player's position has changed negatively in the x direction
        Vector3 finalPosition = playerGameObject.transform.position;
        Debug.Log("Final:" + finalPosition + " Start pos:" + initialPosition);
        Assert.Greater(initialPosition.x, finalPosition.x);
    }

    [UnityTest]
    public IEnumerator Q3PlayerController_MoveForwardTest() {
        Vector3 initialPosition = playerGameObject.transform.position;
        playerController.InputProvider.GetMovementInput().Returns(new Vector2(0.0f, 1.0f));
        playerController.InputProvider.GetDeltaTime().Returns(0.0167f);

        yield return null;
        yield return null;

        // Check if the player's position has changed positively in the z direction
        Vector3 finalPosition = playerGameObject.transform.position;
        Debug.Log("Final:" + finalPosition + " Start pos:" + initialPosition);
        Assert.Greater(finalPosition.z, initialPosition.z);
    }

    [UnityTest]
    public IEnumerator Q3PlayerController_MoveBackwardTest() {
        Vector3 initialPosition = playerGameObject.transform.position;
        playerController.InputProvider.GetMovementInput().Returns(new Vector2(0.0f, -1.0f));
        playerController.InputProvider.GetDeltaTime().Returns(0.0167f);

        yield return null;
        yield return null;

        // Check if the player's position has changed negatively in the z direction
        Vector3 finalPosition = playerGameObject.transform.position;
        Debug.Log("Final:" + finalPosition + " Start pos:" + initialPosition);
        Assert.Greater(initialPosition.z, finalPosition.z);
    }


}