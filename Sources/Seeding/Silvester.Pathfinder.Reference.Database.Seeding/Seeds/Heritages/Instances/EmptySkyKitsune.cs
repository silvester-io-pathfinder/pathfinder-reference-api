using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class EmptySkyKitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("6cc2defd-bcb9-4a74-8fdf-22872970d893");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Empty Sky Kitsune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("971a109e-d5b3-47b1-a05b-18cb11b42c8c"), Type = TextBlockType.Text, Text = "Your spirit is open to the secrets of beyond, granting you greater access to kitsune magic. You gain the Kitsune Spell Familiarity ancestry feat. Your alternate form is a common Medium humanoid ancestry prevalent where you grew up (typically human), called a tailless form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("6370801d-4de9-4993-80c0-8c79be3453cb"), Feats.Instances.KitsuneSpellFamiliarity.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db303ef2-2e31-4988-a421-9ec5f2535186"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kitsune.ID;
        }
    }
}
