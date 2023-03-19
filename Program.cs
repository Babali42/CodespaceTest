using System;
using NUnit.Framework;

namespace testc;

public class TestClass{
    public static void Main(){
    // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World 2!");
    }

    [Test]
    public void Should(){
        Assert.IsTrue(true);
    }
}
