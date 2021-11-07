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
    public class StrongBloodedDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("635245e9-3230-4dab-8b0b-fac29a761c37");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Strong-Blooded Dwarf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your blood runs hearty and strong, and you can shake off toxins. You gain poison resistance equal to half your level (minimum 1), and each of your successful saving throws against a poison affliction reduces its stage by 2, or by 1 for a virulent poison. Each critical success against an ongoing poison reduces its stage by 3, or by 2 for a virulent poison." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.Manual(Guid.Parse(""), "Each of your successful saving throws against a poison affliction reduces its stage by 2, or by 1 for a virulent poison.");
            builder.Manual(Guid.Parse(""), "Each critical success against an ongoing poison reduces its stage by 3, or by 2 for a virulent poison.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 36
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}
