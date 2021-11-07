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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your incredibly small bones allow you to easily compress your body and squeeze through gaps. You gain the Quick Squeeze feat as a bonus feat, even if you aren't trained in Acrobatics. Tight spaces not tight enough to require the Squeeze action aren't difficult terrain for you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.DisableFeatPrerequisites(Guid.Parse(""), Feats.Instances.QuickSqueeze.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.QuickSqueeze.ID);
            builder.Manual(Guid.Parse(""), "Tight spaces not tight enough to require the Squeeze action aren't difficult terrain for you.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
