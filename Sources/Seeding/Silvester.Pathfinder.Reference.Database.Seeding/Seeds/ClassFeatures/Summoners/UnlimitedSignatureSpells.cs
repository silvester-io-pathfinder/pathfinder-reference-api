using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class UnlimitedSignatureSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("d789377a-6898-469b-be2e-df904c75046d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Unlimited Signature Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9363257f-99a8-4ffc-bac2-7a6282207461"), Type = TextBlockType.Text, Text = "All of your spells are signature spells. That means that if you know a spell, you can heighten it freely by casting it from a higher-level spell slot, up to the maximum level of spell you can cast. You can similarly cast any of its lower-level versions without learning them separately." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b06b7970-f4b7-4113-9de6-78617f96208b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
