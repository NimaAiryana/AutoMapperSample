using AutoMapperSample.OneToOneMapping.Entities;

namespace AutoMapperSample.OneToOneMapping.ReadModel
{
    internal class LeftRight
    {
        public LeftRight(Left left, Right right)
        {
            Left = left;
            Right = right;
        }

        public Left Left { get; set; }
        public Right Right { get; set; }
    }
}
