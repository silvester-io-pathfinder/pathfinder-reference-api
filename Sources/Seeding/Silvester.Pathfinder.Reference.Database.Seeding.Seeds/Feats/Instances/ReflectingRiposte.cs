using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectingRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("7714936a-03c8-4d10-867a-11ef7e5931b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflecting Riposte",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent casts a spell and you critically succeed at a saving throw against it.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a229a97-2437-418c-8090-7a7498bbd1d5"), Type = TextBlockType.Text, Text = $"You attempt to counteract the triggering spell using powerful magical techniques observed in the Kortos Mounts. Use your attack roll modifier with your shield or parrying weapon for your counteract check. If you counteract the spell, it is reflected upon the caster. If the spell targeted individual creatures, it targets the caster only. If the spell targeted an area centered on a point, the new area is centered on the caster. If the spell was a cone or line, the cone or line emanates from you toward the caster. If the spell has a save DC, it uses your class DC, and if it requires a spell attack roll, use the same attack roll modifier as the counteract check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1668da9e-364c-4680-97ae-d93ab0e99283"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("1a2bcdbb-bbdf-44cf-b888-d9269ef564d3"), Feats.Instances.DuelingRiposte.ID);
                or.HaveSpecificFeat(Guid.Parse("cb870852-7381-47f2-92f4-bc70c1343da6"), Feats.Instances.MirrorShield.ID);
                or.HaveSpecificFeat(Guid.Parse("426119f3-742c-4719-9dec-03318a70a37a"), Feats.Instances.TwinRiposte.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d22def03-dfa8-4da4-8616-1baa61bc87d3"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
