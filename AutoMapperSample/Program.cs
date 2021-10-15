using AutoMapper.QueryableExtensions;
using AutoMapperSample.OneToManyMapping.Dto;
using AutoMapperSample.OneToManyMapping.ReadModel;
using AutoMapperSample.OneToOneMapping.Dto;
using AutoMapperSample.OneToOneMapping.ReadModel;

Console.WriteLine("One to one mapping");

var oneToOneLefts = AutoMapperSample.OneToOneMapping.Mocks.LeftEntityMock.GetLefts();
var oneToOneRights = AutoMapperSample.OneToOneMapping.Mocks.RightEntityMock.GetRights();

var oneToOneAutoMapperConfig = AutoMapperSample.OneToOneMapping.Configurations.AutoMapperConfiguration.GetMapperConfiguration();

var lambdaOneToOneResultResponseDto = oneToOneLefts.Join(oneToOneRights, l => l.Id, r => r.LeftId,
    (l, r) => new LeftRight(l, r)).AsQueryable().ProjectTo<LeftRightResponseDto>(oneToOneAutoMapperConfig).ToList();

var linqOneToOneResultResponeDto =
    (from l in oneToOneLefts
     join r in oneToOneRights on l.Id equals r.LeftId
     // where ...
     select new LeftRight(l, r)).AsQueryable().ProjectTo<LeftRightResponseDto>(oneToOneAutoMapperConfig).ToList();

Console.WriteLine();
Console.WriteLine("Lambda version");
foreach (var itemDto in lambdaOneToOneResultResponseDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    Console.WriteLine(itemDto.Right?.Name);

    Console.WriteLine("-------------------");
}

Console.WriteLine();
Console.WriteLine("Linq version");
foreach (var itemDto in linqOneToOneResultResponeDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    Console.WriteLine(itemDto.Right?.Name);

    Console.WriteLine("-------------------");
}

Console.WriteLine();
Console.WriteLine("The end one to one mapping");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("One to many mapping");

var oneToManyLefts = AutoMapperSample.OneToManyMapping.Mocks.LeftEntityMock.GetLefts();
var oneToManyRights = AutoMapperSample.OneToManyMapping.Mocks.RightEntityMock.GetRights();

var oneToManyAutoMapperConfig = AutoMapperSample.OneToManyMapping.Configurations.AutoMapperConfiguration.GetMapperConfiguration();

var lambdaOneToManyResultResponseDto = oneToManyLefts.Join(oneToManyRights, l => l.Id, r => r.LeftId,
    (l, r) => new { l, r }).GroupBy(x => x.l).Select(x => new LeftRights(x.Key, x.Select(g => g.r).ToList()))
    .AsQueryable().ProjectTo<LeftRightsResponseDto>(oneToManyAutoMapperConfig).ToList();

var linqOneToManyResultResponseDto =
    (from l in oneToManyLefts
     join r in oneToManyRights on l.Id equals r.LeftId
     // where ...
     group new { l, r } by l into g
     select new LeftRights(g.Key, g.Select(x => x.r).ToList())).AsQueryable().ProjectTo<LeftRightsResponseDto>(oneToManyAutoMapperConfig).ToList();

Console.WriteLine();
Console.WriteLine("Lambda version");
foreach (var itemDto in lambdaOneToManyResultResponseDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    if (itemDto.Rights is null) throw new NullReferenceException("The rights is null");

    foreach (var rightItem in itemDto.Rights)
    {
        Console.WriteLine($"    {rightItem.Id}");
        Console.WriteLine($"    {rightItem.Name}");
    }

    Console.WriteLine("-------------------");
}

Console.WriteLine();
Console.WriteLine("Linq version");
foreach (var itemDto in linqOneToManyResultResponseDto)
{
    Console.WriteLine(itemDto.Left?.Id);
    Console.WriteLine(itemDto.Left?.Title);

    if (itemDto.Rights is null) throw new NullReferenceException("The rights is null");

    foreach (var rightItem in itemDto.Rights)
    {
        Console.WriteLine($"    {rightItem.Id}");
        Console.WriteLine($"    {rightItem.Name}");
    }

    Console.WriteLine("-------------------");
}
Console.WriteLine("The end one to many mapping");

