namespace Miningcore.Api.Responses;

public class GetPoolResponse
{
    public PoolInfo Pool { get; set; }
    public PoolDifficulty[] Difficulties { get; set; }
}
