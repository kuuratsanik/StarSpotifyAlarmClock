﻿using System;

namespace StarSpotifyAlarmClock.Exceptions
{
    public class SpotifyException : Exception
    {
        public SpotifyException()
        {
        }

        public SpotifyException(string message)
            : base(message)
        {
        }

        public SpotifyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}