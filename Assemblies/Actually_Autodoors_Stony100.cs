using RimWorld;
using Verse;

namespace ActuallyAutodoors
{
    public class StatPart_AdvancedAutodoorStoneSpeed : StatPart
    {
        public override void TransformValue(StatRequest req, ref float val)
        {
            if (!req.HasThing)
                return;

            Thing thing = req.Thing;

            if (thing.def.defName != "Advanced_Autodoors")
                return;

            if (thing.Stuff == null ||
                !thing.Stuff.stuffProps.categories.Contains(StuffCategoryDefOf.Stony))
                return;

            val = 1.0f;
        }

        public override string ExplanationPart(StatRequest req)
        {
            return null;
        }
    }
}