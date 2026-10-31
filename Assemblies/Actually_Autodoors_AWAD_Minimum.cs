namespace ActuallyAutodoors
{
    public class StatPart_WideAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Wide_Autodoor";
        protected override float MinimumSpeed => 1.25f;
    }
}
