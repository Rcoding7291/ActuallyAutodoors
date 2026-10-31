using System.Collections.Generic;
using RimWorld;
using Verse;

namespace ActuallyAutodoors
{
    public class StatPart_AutodoorMinimumSpeeds : StatPart
    {
        private static readonly Dictionary<string, float> MinimumSpeeds =
            new Dictionary<string, float>
            {
                { "Reinforced_Wide_Door", 1.25f }, // BRWD; included
                { "Reinforced_Wide_Autodoor", 1.1f },
                { "Reinforced_Doors", 0.9f },
                { "Reinforced_Autodoors", 1.1f },
                { "Advanced_Wide_Autodoor", 1.5f },
                { "Advanced_Reinforced_Wide_Autodoor", 1.5f },
                { "Advanced_Reinforced_Autodoors", 1.5f },
                { "Advanced_Autodoors", 1.5f },
                { "Wide_Autodoor", 1.1f }
            };

        public override void TransformValue(StatRequest req, ref float val)
        {
            ThingDef doorDef = req.HasThing ? req.Thing.def : req.Def as ThingDef;

            if (doorDef != null
                && MinimumSpeeds.TryGetValue(doorDef.defName, out float minimumSpeed)
                && val < minimumSpeed)
            {
                val = minimumSpeed;
            }
        }

        public override string ExplanationPart(StatRequest req)
        {
            return null;
        }
    }
}