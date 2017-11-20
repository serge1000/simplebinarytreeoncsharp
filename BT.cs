using System;

public class BT
{
    public BTN Root { get; set; }

    public BT()
    {
        this.Root = null;
    }

    public void AddNode(int val)
    {
        if (IsEmpty())
        {
            this.Root = new BTN(val);
        }
        else
        {
            this.Root.AddNode(Root, val);
        }

    }
    public bool IsEmpty()
    {
        return this.Root == null;
    }

}
