using System;
using System.Collections.Generic;

namespace MunicipalServicesApp
{
    public class BSTNode
    {
        public string RequestId { get; set; }
        public Issue RequestData { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public BSTNode(string id, Issue data)
        {
            RequestId = id;
            RequestData = data;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        private BSTNode root;

        public void Insert(string id, Issue data)
        {
            root = InsertRec(root, id, data);
        }

        private BSTNode InsertRec(BSTNode root, string id, Issue data)
        {
            if (root == null)
            {
                return new BSTNode(id, data);
            }

            int comparison = string.Compare(id, root.RequestId, StringComparison.OrdinalIgnoreCase);
            if (comparison < 0)
                root.Left = InsertRec(root.Left, id, data);
            else if (comparison > 0)
                root.Right = InsertRec(root.Right, id, data);

            return root;
        }

        public Issue Search(string id)
        {
            BSTNode result = SearchRec(root, id);
            return result?.RequestData;
        }

        private BSTNode SearchRec(BSTNode root, string id)
        {
            if (root == null || root.RequestId.Equals(id, StringComparison.OrdinalIgnoreCase))
                return root;

            if (string.Compare(id, root.RequestId, StringComparison.OrdinalIgnoreCase) < 0)
                return SearchRec(root.Left, id);

            return SearchRec(root.Right, id);
        }

        public List<Issue> GetAllInOrder()
        {
            List<Issue> list = new List<Issue>();
            InOrderRec(root, list);
            return list;
        }

        private void InOrderRec(BSTNode root, List<Issue> list)
        {
            if (root != null)
            {
                InOrderRec(root.Left, list);
                list.Add(root.RequestData);
                InOrderRec(root.Right, list);
            }
        }
    }
}
