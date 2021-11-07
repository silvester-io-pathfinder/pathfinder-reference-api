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
    public class WishbornPoppet : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wishborn Poppet"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You were wished to life, either by a powerful spellcaster or by the earnest desire of an innocent person who loved you very much. You're living proof that a hopeful spirit can overcome any obstacle. If you roll a success on a saving throw against an emotion or fear effect, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse(""), Traits.Instances.Emotion.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse(""), Traits.Instances.Fear.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 63
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Poppet.ID;
        }
    }
}
