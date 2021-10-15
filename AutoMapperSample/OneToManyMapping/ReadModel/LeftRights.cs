using AutoMapperSample.OneToManyMapping.Entities;

namespace AutoMapperSample.OneToManyMapping.ReadModel
{
    internal class LeftRights
    {
        public LeftRights()
        {

        }

        public LeftRights(Left left, List<Right> rights)
        {
            Left = left;
            Rights = rights;
        }

        public Left? Left { get; set; }
        public List<Right>? Rights { get; set; }
    }
}
