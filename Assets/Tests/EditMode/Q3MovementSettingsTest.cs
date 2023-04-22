using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using Q3Movement;

public class Q3MovementSettingsTests {
    [Test]
    public void MovementSettings_InitializeCorrectly() {
        float maxSpeed = 10.0f;
        float acceleration = 5.0f;
        float deceleration = 2.0f;

        MovementSettings settings = new MovementSettings(maxSpeed, acceleration, deceleration);

        Assert.AreEqual(maxSpeed, settings.MaxSpeed);
        Assert.AreEqual(acceleration, settings.Acceleration);
        Assert.AreEqual(deceleration, settings.Deceleration);
    }
}