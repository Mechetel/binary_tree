using System;
using System.Collections.Generic;

namespace apriorit
{
    public interface ITraversalStrategy<T> where T : IComparable<T>
    {
        IEnumerator<T> Traversal(BinaryTreeNode<T> node);
    }
}
