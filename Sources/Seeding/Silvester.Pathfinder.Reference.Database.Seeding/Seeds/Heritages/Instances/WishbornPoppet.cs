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
        public static readonly Guid ID = Guid.Parse("678b48d5-cc81-479d-a0f9-17721f22eaa1");

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
            yield return new TextBlock { Id = Guid.Parse("01f5baac-a2c3-4080-8eb6-2198d31d7b5f"), Type = TextBlockType.Text, Text = "You were wished to life, either by a powerful spellcaster or by the earnest desire of an innocent person who loved you very much. You're living proof that a hopeful spirit can overcome any obstacle. If you roll a success on a saving throw against an emotion or fear effect, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("5019202d-1a9d-4a0c-90b3-855aec225209"), Traits.Instances.Emotion.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("fe1571a9-78db-403c-b571-61608520b41e"), Traits.Instances.Fear.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5797afc-98b3-425c-a490-4be4136c8a86"),
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
