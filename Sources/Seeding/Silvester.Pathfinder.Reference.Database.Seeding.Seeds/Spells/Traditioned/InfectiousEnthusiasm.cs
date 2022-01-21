using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InfectiousEnthusiasm : Template
    {
        public static readonly Guid ID = Guid.Parse("165c330d-7941-40b6-9228-4dcc660561f9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Infectious Enthusiasm",
                Level = 1,
                Duration = "1 round.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("967fd7da-1bac-4c2e-a819-b03a05e52c81"), Type = TextBlockType.Text, Text = "With enchanted gusto, you encourage yourself to get things done and share your motivation with your allies. You gain a +1 status bonus to your choice of attack rolls, Will saves, or Charisma-based skill checks. During the spell�s duration, an ally who observed you Casting this Spell and was within 30 feet when you did so can take a single action, which has the concentrate trait, to gain the same bonus you chose until the start of its next turn." };
            yield return new TextBlock { Id = Guid.Parse("b06429e0-faa0-4966-8530-9be4d5e1b342"), Type = TextBlockType.Text, Text = "Using this spell to influence someone in a social situation is typically considered a faux pas, negating the benefit on Charisma-based skills if the subject of the check observed you casting the spell." };
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
            builder.Add(Guid.Parse("db456dc4-0f14-4a6a-b212-c1034836f09b"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("06261647-778a-4065-82ab-82fc49af04bf"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("726f3cc9-ec9a-43eb-aedb-25f754ff5616"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("43b739cd-f7da-4f65-b083-36be34089989"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7dcb1853-1acb-4ec3-90d3-f48cb9aa8522"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 112
            };
        }
    }
}