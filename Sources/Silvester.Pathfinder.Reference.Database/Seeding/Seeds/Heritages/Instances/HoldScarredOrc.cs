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
    public class HoldScarredOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Hold-Scarred Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are part of an orc community that participates in ritual scarification or tattooing. The marks on your skin show your exceptional hardiness and vitality. You gain 12 Hit Points from your ancestry instead of 10. You also gain the Diehard feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestryHitpoints(Guid.Parse(""), ModifierType.Add, modifier: 2);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Diehard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 18
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
