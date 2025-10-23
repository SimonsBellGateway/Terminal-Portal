
namespace ConsoleInterface
{
    class Frame
    {
        private char[,] theMatrix;
        private int height, width;

        public Frame(int newHeight, int newWidth)
        {
            width = newWidth;
            height = newHeight;
            theMatrix = new char[height, width];
        }

        //  Operations with theMatrix
        public char[,] GetTheMatrix()
        {
            return theMatrix;
        }
        public void setTheMatrix(char[,] newTheMatrix)
        {
            theMatrix = newTheMatrix;
        }
        public void SetACharOnTheMatrix(char newChar, int posY, int posX)
        {
            theMatrix[posY, posX] = newChar;
        }

        //  The height operations
        public int GetHeight()
        {
            return height;
        }
        public void SetHeight(int newHeight)
        {
            height = newHeight;
        }

        //  The very width operations
        //  Using the following function with CaseOh is not recomended! 
        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int newWidth)
        {
            width = newWidth;
        }
    }
}