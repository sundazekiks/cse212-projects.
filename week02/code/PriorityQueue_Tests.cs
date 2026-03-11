using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue that adds (bob, 20), (tim, 300), ("sue", 30), ("jay", 100) in order
    // Expected Result: (bob, 20), (tim, 300), ("sue", 30), ("jay", 100)
    // Defect(s) Found: The ToString method on PriorityQueue class return a string so I enclosed my values into a string to match
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        var bob = new PriorityItem("bob", 20);
        var tim = new PriorityItem("tim", 300);
        var sue = new PriorityItem("sue", 30);
        var jay = new PriorityItem("jay", 100);
        string[] values = new string[] { bob.ToString(), tim.ToString(), sue.ToString() };

        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        Assert.AreEqual($"[{string.Join(", ", values)}]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Create a queue and then dequeue the Person with the highest priority number
    // Expected Result: tim
    // Defect(s) Found: Adjust the for loop inside the Dequeue method so it doesn't skip the last element or the first
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        var bob = new PriorityItem("bob", 20);
        var tim = new PriorityItem("tim", 300);
        var sue = new PriorityItem("sue", 30);
        var jay = new PriorityItem("jay", 100);

        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        Assert.AreEqual(tim.Value, priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}