using AutoMapperSample.OneToOneMapping.Entities;

namespace AutoMapperSample.OneToOneMapping.Mocks
{
    internal class RightEntityMock
    {
        public static IList<Right> GetRights()
        {
            return new List<Right>()
            {
                new Right(1, "Nima Name"),
                new Right(2, "Niusha Name")
            };
        }
    }
}
