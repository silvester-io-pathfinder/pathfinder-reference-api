using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AttunementShift : Template
    {
        public static readonly Guid ID = Guid.Parse("19aeabb2-d5da-49e1-8473-3471c71cb4e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Attunement Shift",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd8d0bda-f5b0-485d-9a2b-5ac11c0b8a62"), Type = TextBlockType.Text, Text = "The magic of your spell floods into you, overriding your connection to the land around you. You alter your terrain attunement to a terrain that matches a trait of the spell you just cast. You thereby gain your terrain attunement benefit when you cast further spells with the same descriptor, instead of using the terrain you’re actually in. For instance, if you cast (spell: tanglefoot), your terrain attunement switches to your choice of forest or swamp, and your terrain attunement applies when you cast another plant spell." };
            yield return new TextBlock { Id = Guid.Parse("fdd6fe20-478b-4874-a85c-cb7d54364a13"), Type = TextBlockType.Text, Text = "Your terrain attunement reverts to that of the terrain you’re in 1 minute after you use Attunement Shift." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7124eab6-ede8-4f8a-bcbe-6bc155b3b46c"), Feats.Instances.GeomancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8ceea87-d471-4e10-92f9-aa4dffae150e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
