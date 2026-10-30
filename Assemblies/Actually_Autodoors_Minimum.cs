using RimWorld;
using Verse;

namespace ActuallyAutodoors
{
    public abstract class StatPart_DoorMinimumSpeed : StatPart
    {
        protected abstract string DoorDefName { get; }
        protected abstract float MinimumSpeed { get; }

        public override void TransformValue(StatRequest req, ref float val)
        {
            if (req.HasThing && req.Thing.def.defName == DoorDefName && val < MinimumSpeed)
                val = MinimumSpeed;
        }

        public override string ExplanationPart(StatRequest req)
        {
            return null;
        }
    }

    public class StatPart_AdvancedAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Advanced_Autodoors";
        protected override float MinimumSpeed => 1.25f;
    }

    public class StatPart_ReinforcedAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Reinforced_Autodoors";
        protected override float MinimumSpeed => 0.75f;
    }

    public class StatPart_AdvancedReinforcedAutodoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Advanced_Reinforced_Autodoors";
        protected override float MinimumSpeed => 1.0f;
    }

    public class StatPart_ReinforcedDoorMinimumSpeed : StatPart_DoorMinimumSpeed
    {
        protected override string DoorDefName => "Reinforced_Doors";
        protected override float MinimumSpeed => 0.45f;
    }
}