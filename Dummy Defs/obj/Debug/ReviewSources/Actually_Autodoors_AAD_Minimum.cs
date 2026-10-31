namespace ActuallyAutodoors
{
    public class StatPart_AdvancedAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Advanced_Autodoors";
        protected override float MinimumSpeed => 1.0f;
    }
}
