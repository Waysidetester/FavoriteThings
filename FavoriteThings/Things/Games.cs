using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Games
    {
        // props
        public GameGenres GameGenre { get; protected set; }
        public string Title { get; protected set; }

        // constructor
        public Games(string title)
        {
            Title = title;
        }


        // methods
        public void SetGenre(GameGenres assignedGenre)
        {
            GameGenre = assignedGenre;
        }

        public string NameOfGame()
        {
            return Title;
        }
    }

    enum GameGenres
    {
        action = 1,
        FPS,
        casual,
        RTS,
        MOBA,
        racing,
        simulation,
        western
    }
}
