using System.Diagnostics;

public class SequencePacker<T> : IEnumerable<T>
{
    [DebuggerDisplay("{Count}x {Element}")]
    private record Node<TElement>(TElement t)
    {
        public TElement Element { get; private init; } = t;
        public int Count { get; internal set; } = 1;
    }

    private readonly List<Node<T>> _nodes;

    public SequencePacker()
    {
        _nodes = [];
    }

    public void Clear()
    {
        _nodes.Clear();
    }

    public void Add(T t)
    {
        bool handled = false;
        if (_nodes.Count > 0)
        {
            Node<T> lastNode = _nodes[^1];
            if (lastNode.Element!.Equals(t))
            {
                lastNode.Count++;
                handled = true;
            }
        }

        if (handled is false)
        {
            _nodes.Add(new Node<T>(t));
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (Node<T> node in _nodes)
        {
            for (int i = 0; i < node.Count; i++)
            {
                yield return node.Element;
            }
        }
    }
}