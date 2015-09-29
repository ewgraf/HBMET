using System;

namespace nn4
{
    public class Statistica
    {
        #region Inner-fields
        private uint up;
        private uint right;
        private uint down;
        private uint left;
        #endregion

        public Statistica()
        {
            up = 0; right = 0; down = 0; left = 0;
        }

        #region Increment-inner-fields-methods
        public void AddUp() { up++; }
        public void AddRight() { right++; }
        public void AddDown() { down++; }
        public void AddLeft() { left++; }
        #endregion

        #region Public-properties
        public uint Up { get { return up; } }
        public uint Right { get { return right; } }
        public uint Down { get { return down; } }
        public uint Left { get { return left; } }
        #endregion
    }
}