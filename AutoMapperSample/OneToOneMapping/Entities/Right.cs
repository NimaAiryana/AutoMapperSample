namespace AutoMapperSample.OneToOneMapping.Entities
{
    internal class Right
    {
        public Right(long leftId, string? name)
        {
            LeftId = leftId;
            Name = name;
        }

        public long LeftId { get; set; }
        public string? Name { get; set; }
    }
}
