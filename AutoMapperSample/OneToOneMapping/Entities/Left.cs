namespace AutoMapperSample.OneToOneMapping.Entities
{
    internal class Left
    {
        public Left(long id, string? title)
        {
            Id = id;
            Title = title;
        }

        public long Id { get; set; }
        public string? Title { get; set; }
    }
}
