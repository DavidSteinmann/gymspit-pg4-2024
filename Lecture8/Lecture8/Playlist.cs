using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal class Playlist : IEnumerable<Song>
    {
        internal List<Song> songs = new List<Song>();

        public Playlist(List<Song> songs)
        {
            this.songs = songs;
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return new PlaylistEnumeratorBasic(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PlaylistEnumeratorBasic(this);
        }
    }
}
