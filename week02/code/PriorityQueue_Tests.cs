using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities
// Expected Result: Item with highest priority is returned
// Defect(s) Found: Dequeue did not always return the highest-priority item.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("B", result);


    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority
    // Expected Result: The earliest inserted item is removed first
    // Defect(s) Found: Tie-breaking was incorrect due to >= comparison.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 1);

        var result = pq.Dequeue();

        Assert.AreEqual("A", result);
    }



    [TestMethod]
    // Scenario: Dequeue removes the item from the queue
    // Expected Result: Queue size decreases after dequeue
    // Defect(s) Found: Dequeue returned value but did not remove it.
    public void TestPriorityQueue_Removal()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 1);

        pq.Dequeue();

        Assert.AreEqual("[B (Pri:1)]", pq.ToString());
    }

}