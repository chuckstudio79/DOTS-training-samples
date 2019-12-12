
using Unity.Entities;

public struct AntSteeringComponent : IComponentData
{
	public float RandomDirection;
	public float PheromoneSteering;
	public float TargetSteering;
	public float WallSteering;
}
