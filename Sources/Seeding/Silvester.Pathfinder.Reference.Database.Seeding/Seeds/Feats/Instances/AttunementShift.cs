using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AttunementShift : Template
    {
        public static readonly Guid ID = Guid.Parse("a9474ef1-14e8-4330-b4df-62fdc5cdfc5c");

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
            yield return new TextBlock { Id = Guid.Parse("b3136e42-301c-479f-aaca-9e751dcd9118"), Type = TextBlockType.Text, Text = "The magic of your spell floods into you, overriding your connection to the land around you. You alter your terrain attunement to a terrain that matches a trait of the spell you just cast. You thereby gain your terrain attunement benefit when you cast further spells with the same descriptor, instead of using the terrain you’re actually in. For instance, if you cast (spell: tanglefoot), your terrain attunement switches to your choice of forest or swamp, and your terrain attunement applies when you cast another plant spell." };
            yield return new TextBlock { Id = Guid.Parse("a9865903-6828-413c-9c9f-9167dcc2fc52"), Type = TextBlockType.Text, Text = "Your terrain attunement reverts to that of the terrain you’re in 1 minute after you use Attunement Shift." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd9dd977-6473-4555-b51f-0aa230fbd41b"), Feats.Instances.GeomancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9cc7cc7-7a75-4f5c-86af-74b701a56715"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
