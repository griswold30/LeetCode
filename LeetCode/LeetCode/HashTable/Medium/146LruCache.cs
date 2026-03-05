namespace LeetCode.HashTable.Medium
{
    public class _146LruCache
    {
        private readonly int _capacity;
        private readonly LinkedList<CacheItem> _lruList = new LinkedList<CacheItem>();
        private readonly Dictionary<int, LinkedListNode<CacheItem>> _cache;
        
        public _146LruCache (int capacity)
        {
            _capacity = capacity;
            _cache = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
        }

        public int Get(int key)
        {
            if (_cache.TryGetValue(key, out var node))
            {
                BringToFront(node);
                return node.Value.Value;
            }

            return -1;
        }


        private void BringToFront(LinkedListNode<CacheItem> node)
        {
            if (node != _lruList.First)
            {
                _lruList.Remove(node);
                _lruList.AddFirst(node);
            }
        }

        public void Put(int key, int value)
        {
            if (_capacity <= 0) return;

            if (_cache.TryGetValue(key, out var node))
            {
                node.Value.Value = value;
                BringToFront(node);
            }
            else
            {
                if (_cache.Count == _capacity)
                {
                    Evict();
                }

                node = new LinkedListNode<CacheItem>(new CacheItem(key, value));
                _lruList.AddFirst(node);
                _cache[key] = node;
            }
        }

        private void Evict()
        {
            var last = _lruList.Last!;
            _cache.Remove(last.Value.Key);
            _lruList.RemoveLast();
        }

        private sealed class CacheItem
        {
            public int Key { get; }
            public int Value { get; set; }

            public CacheItem(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}