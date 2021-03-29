using System;
using Godot;

namespace GdSharpHelpers
{
    public static class NodeExtensions
    {
        public static Lazy<T> FindNodeLazy<T>(this Node parent, string nameOfNodeToFind) where T : class
        {
            return new Lazy<T>(() => parent.FindNode(nameOfNodeToFind) as T);
        }

        public static Lazy<T> GetNodeLazy<T>(this Node parent, string nameOfNodeToFind) where T : class
        {
            return new Lazy<T>(() => parent.GetNode<T>(nameOfNodeToFind));
        }
    }
}