using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal class PlaylistEnumeratorBasic : IEnumerator<Song>
    {
        private Playlist list;

        // Start on -1 because MoveNext gets called before the first element
        private int index = -1;

        public PlaylistEnumeratorBasic(Playlist list)
        {
            this.list = list;
        }

        public Song Current => list.songs[index];

        object IEnumerator.Current => list.songs[index];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index += 1;

            if (index >= list.songs.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
