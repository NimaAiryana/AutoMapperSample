using AutoMapper;
using AutoMapper.QueryableExtensions;

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Left, LeftResponseDto>();
    cfg.CreateMap<Right, RightResponseDto>();
    cfg.CreateMap<LeftRight, LeftRightResponseDto>();
});


var lefts = new List<Left>()
{
    new Left(1, "Nima Title"),
    new Left(2, "Shima Title")
};

var rights = new List<Right>()
{
    new Right(1, "Nima Name"),
    new Right(2, "Shima Name")
};

var resultResponseDto = lefts.Join(rights, l => l.Id, r => r.LeftId, (l, r) => new LeftRight(l, r)).AsQueryable().ProjectTo<LeftRightResponseDto>(config).ToList();

var linq =
    (from l in lefts
     join r in rights on l.Id equals r.LeftId
     // where ..
     select new LeftRight(l, r)).AsQueryable().ProjectTo<LeftRightResponseDto>(config).ToList();

foreach (var itemDto in resultResponseDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    Console.WriteLine(itemDto.Right?.Name);

    Console.WriteLine("-------------------");
}

foreach (var itemDto in linq)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    Console.WriteLine(itemDto.Right?.Name);

    Console.WriteLine("-------------------");
}

class Left
{
    public Left(long id, string? title)
    {
        Id = id;
        Title = title;
    }

    public long Id { get; set; }
    public string? Title { get; set; }
}

class Right
{
    public Right(long leftId, string? name)
    {
        LeftId = leftId;
        Name = name;
    }

    public long LeftId { get; set; }
    public string? Name { get; set; }
}

class LeftRight
{
    public LeftRight(Left left, Right right)
    {
        Left = left;
        Right = right;
    }

    public Left Left { get; set; }
    public Right Right { get; set; }
}

class LeftResponseDto
{
    public long Id { get; set; }
    public string? Title { get; set; }
}

class RightResponseDto
{
    public string? Name { get; set; }
}

class LeftRightResponseDto
{
    public LeftResponseDto? Left { get; set; }
    public RightResponseDto? Right { get; set; }
}
