﻿namespace Demo
{
    public class Position
    {
        private int x;
        private int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X => this.x;
        public int Y => this.y;
    }
}
