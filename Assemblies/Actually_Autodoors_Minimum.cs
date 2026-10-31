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

}