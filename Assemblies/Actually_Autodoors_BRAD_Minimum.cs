namespace ActuallyAutodoors
{
    public class StatPart_ReinforcedAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Reinforced_Autodoors";
        protected override float MinimumSpeed => 0.9f;
    }
}
