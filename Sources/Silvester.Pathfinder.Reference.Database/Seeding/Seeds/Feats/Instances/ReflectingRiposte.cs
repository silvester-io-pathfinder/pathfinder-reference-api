using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectingRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("feff2f1d-e485-4b86-abbd-33f792ee5863");

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
            yield return new TextBlock { Id = Guid.Parse("a8dd6ea1-abf9-49b7-8979-b32f003e4a93"), Type = TextBlockType.Text, Text = "You attempt to counteract the triggering spell using powerful magical techniques observed in the Kortos Mounts. Use your attack roll modifier with your shield or parrying weapon for your counteract check. If you counteract the spell, it is reflected upon the caster. If the spell targeted individual creatures, it targets the caster only. If the spell targeted an area centered on a point, the new area is centered on the caster. If the spell was a cone or line, the cone or line emanates from you toward the caster. If the spell has a save DC, it uses your class DC, and if it requires a spell attack roll, use the same attack roll modifier as the counteract check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("077a7555-db08-454e-ac59-3d821df58c01"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("62b9a8b1-a39d-4928-b90c-595edb3e0080"), Feats.Instances.DuelingRiposte.ID);
                or.HaveSpecificFeat(Guid.Parse("26095e60-a64e-4fff-a4ac-84e54e552c92"), Feats.Instances.MirrorShiled.ID);
                or.HaveSpecificFeat(Guid.Parse("eb4e6db0-f6d8-4d1f-9ad2-cb57eef8efcb"), Feats.Instances.TwinRiposte.ID);
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
                Id = Guid.Parse("57e44964-4961-4300-80dd-eca051422761"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
