using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class DoubleSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("769ee3fb-21f2-4bfd-b21a-2e8188e9a3f1");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Double Spellstrike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c0fa0ad0-3f31-42b6-b8b5-d5d3b37f75a2"), Type = TextBlockType.Text, Text = "You can extend the magic of spells you store with Spellstrike. After you make a Spellstrike with a spell cast from a spell slot, you retain an echo of the spell, stored in your body. The next time you Spellstrike, you can cast the same spell again without expending a spell slot." };
            yield return new TextBlock { Id = Guid.Parse("953beccc-3655-4148-b837-24649400301f"), Type = TextBlockType.Text, Text = "If you choose to cast a different spell with Spellstrike, or you go 1 minute without using the stored spell, the stored spell dissipates harmlessly." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73e74ee8-ef34-46f6-9f57-fa68a4dc0eca"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
