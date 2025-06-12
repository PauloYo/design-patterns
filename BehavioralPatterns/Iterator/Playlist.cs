using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace BehavioralPatterns.Iterator
{
    public class Playlist : IEnumerable<string>
    {
        private readonly List<string> _songs = new List<string>();
        private bool _randomOrder = false;

        public void Add(string song)
        {
            _songs.Add(song);
        }

        public void SetRandomOrder(bool random)
        {
            _randomOrder = random;
        }

        public IEnumerator<string> GetEnumerator()
        {
            if (_randomOrder)
            {
                var random = new Random();
                var shuffled = _songs.OrderBy(x => random.Next()).ToList();
                return shuffled.GetEnumerator();
            }
            return _songs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}