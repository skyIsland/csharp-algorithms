﻿/*
 * 二叉树遍历?
 */
using System;

namespace BitreeTraversal
{
    public class BitreeNode
    {
        public int Value { get; set; }

        public BitreeNode Left { get; set; }

        public BitreeNode Right { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BitreeNode
            {
                Value = 5,
                Left = new BitreeNode
                {
                    Value = 7,
                    Left = new BitreeNode
                    {
                        Value = 1
                    },
                    Right = new BitreeNode
                    {
                        Value = 2
                    }
                },
                Right = new BitreeNode
                {
                    Value = 13,
                    Left = new BitreeNode
                    {
                        Value = 6
                    },
                    Right = new BitreeNode
                    {
                        Value = 3
                    }
                }
            };

            Preorder(tree);
            Console.WriteLine();
            Inorder(tree);
            Console.WriteLine();
            Postorder(tree);
            Console.Read();
        }

        static void Preorder(BitreeNode node)
        {
            if (node == null)
                return;
            Console.Write(node.Value + " ");
            Preorder(node.Left);
            Preorder(node.Right);
        }

        static void Inorder(BitreeNode node)
        {
            if (node == null)
                return;
            Inorder(node.Left);
            Console.Write(node.Value + " ");
            Inorder(node.Right);
        }

        static void Postorder(BitreeNode node)
        {
            if (node == null)
                return;
            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write(node.Value + " ");
        }
    }
}
