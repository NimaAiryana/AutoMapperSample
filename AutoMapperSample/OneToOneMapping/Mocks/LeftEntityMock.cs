using AutoMapperSample.OneToOneMapping.Entities;

namespace AutoMapperSample.OneToOneMapping.Mocks
{
    internal class LeftEntityMock
    {
        public static IList<Left> GetLefts()
        {
            return new List<Left>()
            {
                new Left(1, "Nima Title"),
                new Left(2, "Niusha Title")
            };
        }
    }
}
