using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VariableGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("ea8ab060-7313-4f35-bd53-79849dac06c9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Variable Gravity",
                Level = 4,
                Duration = "5 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40cbe6a1-bf63-4a19-b10e-7ebebf0fbaf7"), Type = TextBlockType.Text, Text = "You can adjust how strongly gravity grips you, changing between low gravity, normal gravity, and high gravity with ease. Choose one type of gravity when you cast the spell. While the spell lasts, you can change the type of gravity with a single action, which has the concentrate trait. The spell doesn't alter your physical appearance, so it's impossible to what type of gravity you're subjected to by casual observation." };
            yield return new TextBlock { Id = Guid.Parse("80844ad7-306e-4bd8-95fd-c69b2deaa10d"), Type = TextBlockType.Heading, Text = "Low Gravity" };
            yield return new TextBlock { Id = Guid.Parse("d5962cb6-71fa-4488-8140-5bb28fff7479"), Type = TextBlockType.Text, Text = "You can jump double the normal distance when you Long Jump or Leap, though still to a maximum of your Speed. When you High Jump, you can use the calculation for a Long Jump but don't double the distance. Rather than the normal calculation for falling damage, when you fall, you take no damage for the first 10 feet and then take bludgeoning damage equal to a quarter of the remaining distance you fell. Abilities that adjust how much falling damage you take still apply." };
            yield return new TextBlock { Id = Guid.Parse("e536cb67-57b4-4abf-8bf1-fc0210a493ce"), Type = TextBlockType.Heading, Text = "High Gravity" };
            yield return new TextBlock { Id = Guid.Parse("9b7702ad-29ea-45c3-9fad-4e361b43e593"), Type = TextBlockType.Text, Text = "You become encumbered. You gain a +2 status bonus to your saving throws and DCs to resist forced movement and attempts to knock you prone. You reduce the distance forced movement moves you by half or 10 feet, whichever is more. You can only jump half as high and far. Rather than the normal calculation for falling damage, you take bludgeoning damage equal to the distance you fall. Abilities that adjust how much falling damage you take still apply." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cf606f11-b302-438c-a1d2-622bae9aa21a"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("886c04b7-df0d-4238-ac47-cdaeb5038dde"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9eeff7f3-d05b-49ee-99fc-0e1ba7fb6497"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1104373b-3535-4c04-81db-927ed53eae46"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 138
            };
        }
    }
}
