namespace ActuallyAutodoors
{
    public class StatPart_AdvancedReinforcedAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Advanced_Reinforced_Autodoors";
        protected override float MinimumSpeed => 1.1f;
    }
}
