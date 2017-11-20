using System;

public class BTN
{
    public int Val { get; set; }
    public BTN Left { get; set; }
    public BTN Right { get; set; }

    public BTN(int val)
    {
        this.Val = val;
        this.Left = null;
        this.Right = null;
    }

    public void AddNode(BTN rootNode, int val)
    {
        if (val < rootNode.Val)
        {
            if (rootNode.Left == null)
            {
                rootNode.Left = new BTN(val);
            }
            else
            {
                AddNode(this.Left, val);
            }
        }
        else if (val > rootNode.Val)
        {
            if (rootNode.Right == null)
            {
                rootNode.Right = new BTN(val);
            }
            else
            {
                AddNode(this.Right, val);
            }
        }

    }
}
