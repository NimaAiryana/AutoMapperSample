using AutoMapperSample.OneToManyMapping.Entities;

namespace AutoMapperSample.OneToManyMapping.Mocks
{
    internal class LeftEntityMock
    {
        public static IList<Left> GetLefts()
        {
            return new List<Left>()
            {
                new Left(1, "One"),
                new Left(2, "Two"),
                new Left(3, "Three")
            };
        }
    }
}
