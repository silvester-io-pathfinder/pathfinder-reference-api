using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class TunnelRat : Template
    {
        public static readonly Guid ID = Guid.Parse("e6faa930-ddba-46de-93f7-4e54a93eb5c4");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Tunnel Rat"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1809c79a-8d0d-4d18-ac6b-80880c8ff427"), Type = TextBlockType.Text, Text = "Your incredibly small bones allow you to easily compress your body and squeeze through gaps. You gain the Quick Squeeze feat as a bonus feat, even if you aren't trained in Acrobatics. Tight spaces not tight enough to require the Squeeze action aren't difficult terrain for you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.DisableFeatPrerequisites(Guid.Parse("527cd71b-f3f3-4392-a421-af9ea3b57dcd"), Feats.Instances.QuickSqueeze.ID);
            builder.GainSpecificFeat(Guid.Parse("2461d29a-7d23-46f4-9d7b-eb088fade0dc"), Feats.Instances.QuickSqueeze.ID);
            builder.Manual(Guid.Parse("19c6d6a4-e735-4d28-887b-084fef92640c"), "Tight spaces not tight enough to require the Squeeze action aren't difficult terrain for you.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac6f3a25-e60a-4236-81ff-3126c1047f8d"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 54
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Ratfolk.ID;
        }
    }
}
