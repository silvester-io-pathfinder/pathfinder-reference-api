using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ScorchingRay : Template
    {
        public static readonly Guid ID = Guid.Parse("7eebd9a3-9605-44d9-9ae1-6761c646f968");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Scorching Ray",
                Level = 2,
                Range = "60 feet.",
                Targets = "1 or more creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d1e2382-4c07-4d86-bc92-5066aebc35e9"), Type = TextBlockType.Text, Text = "You fire a ray of heat and flame. Make a spell attack roll against a single creature. On a hit, the target takes 2d6 fire damage, and on a critical hit, the target takes double damage." };
            yield return new TextBlock { Id = Guid.Parse("5efa1ee2-d2b7-4faa-a4a7-28873ceb242e"), Type = TextBlockType.Text, Text = "For each additional action you use when Casting the Spell, you can fire an additional ray at a different target, to a maximum of three rays targeting three different targets for 3 actions. These attacks each increase your multiple attack penalty, but you don't increase your multiple attack penalty until after you make all the spell attack rolls for scorching ray. If you spend 2 or more actions Casting the Spell, the damage increases to 4d6 fire damage on a hit, and it still deals double damage on a critical hit." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9dda9f26-7707-481b-8ab4-fa6b1d11a875"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("a73d2d3b-2bc0-4cff-81b0-d37a5d138abf"), Type = TextBlockType.Text, Text = "The damage to each target increases by 1d6 for the 1-action version, or by 2d6 for the 2-action and 3-action versions." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0307e0b1-f7d4-4354-b1c7-790c9c91cd34"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("8a079fb8-6be3-42a8-9f62-00edac227ebf"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b9230bea-d5c0-40fd-a607-8faf010f3854"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ad0d6e0-220a-4fe7-98de-d11b6da5b899"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 127
            };
        }
    }
}
