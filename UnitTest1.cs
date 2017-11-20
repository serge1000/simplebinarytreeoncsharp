using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // arrays to initialize  test binary trees
        int[] arrayForTree1 = { 12, 5, 3, 60, 100 };
        int[] arrayForTree2 = { 12, 5, 3, 44, 100 };
        int[] arrayForTree3 = { 12, 5, 3, 60, 100 };

        // create binary trees
        BT Tree1 = new BT();
        BT Tree2 = new BT();
        BT Tree3 = new BT();

        [TestInitialize()]
        public void Initialize()
        {
            // Initialize trees
            for (int i = 0; i < 5; i++)
            {
                Tree1.AddNode(arrayForTree1[i]);
                Tree2.AddNode(arrayForTree2[i]);
                Tree3.AddNode(arrayForTree3[i]);
            }
        }

        // Compare two equal trees
        [TestMethod]
        public void CompareMethodTest1()
        {
            
            Assert.IsTrue(BinaryTreeHelper.Compare(Tree1.Root, Tree3.Root), "The trees ARE EQUAL");
        }

        // Compare two not equal trees
        [TestMethod]
        public void CompareMethodTest2()
        {
            Assert.IsFalse(BinaryTreeHelper.Compare(Tree1.Root, Tree2.Root), "The trees ARE NOT EQUAL");
        }
    }
}
