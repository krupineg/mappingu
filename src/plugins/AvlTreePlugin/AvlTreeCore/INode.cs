﻿namespace AvlTreeCore
{
    public interface INode<T>
    {
        T Key { get; set; }

        INode<T> Left { get; set; }

        INode<T> Right { get; set; }

        int Height { get; set; }
    }
}