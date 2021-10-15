using AutoMapperSample.OneToManyMapping.Entities;

namespace AutoMapperSample.OneToManyMapping.Mocks
{
    internal class RightEntityMock
    {
        public static IList<Right> GetRights()
        {
            return new List<Right>()
            {
                new Right(1, 1, "Right One Left One"),
                new Right(2, 1, "Right Two Left One"),
                new Right(3, 1, "Right Three Left One"),
                new Right(4, 2, "Right Four Left Two")
            };
        }
    }
}
