namespace AutoMapperSample.OneToManyMapping.Entities
{
    internal class Right
    {
        public Right()
        {

        }
        public Right(long id, long leftId, string? name)
        {
            Id = id;
            LeftId = leftId;
            Name = name;
        }

        public long Id { get; set; }
        public long LeftId { get; set; }
        public string? Name { get; set; }
    }
}
