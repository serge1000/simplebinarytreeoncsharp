using System;

public static class BinaryTreeHelper
{
    public static bool Compare(BTN t1, BTN t2)
    {
        if (t1 == null && t2 == null)
        {
            return true;
        }
        else if (t1 == null || t2 == null)
        {
            return false;
        }

        bool leftNodesAreEqual = Compare(t1.Left, t2.Left);
        bool rightNodesAreEqual = Compare(t1.Right, t2.Right);

        return t1.Val == t2.Val && leftNodesAreEqual && rightNodesAreEqual;
    }
}
