using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MoonFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("ea580e26-250c-48ee-83ee-c611d49cf2c9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Moon Frenzy",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "Up to 5 willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c45b379f-ea80-4147-bdd9-c1ed9ef97bfd"), Type = TextBlockType.Text, Text = "A feral aspect overcomes the targets, making them tough and savage. Targets gain 5 temporary Hit Points, a +10-foot status bonus to their Speeds, and weakness 5 to silver. They also grow vicious fangs and claws, which are unarmed attacks. The fangs deal 2d8 piercing damage; the claws deal 2d6 slashing damage and have the agile and finesse traits. The targets use their highest weapon or unarmed attack proficiency with these attacks, and if they have weapon specialization or greater weapon specialization, they add this damage as well. On a critical hit with one of these unarmed attacks, the creature struck takes 1d4 persistent bleed damage." };
            yield return new TextBlock { Id = Guid.Parse("36ed9152-bfd7-4e5d-aca3-25dd14281c51"), Type = TextBlockType.Text, Text = "The targets can’t use concentrate actions unless those actions also have the rage trait, with the exception of Seek. A creature can attempt to end the spell’s effect on itself by using a single action, which has the rage trait, to attempt a Will save against your spell DC; on a success, it ends the spell’s effect on itself." };
            yield return new TextBlock { Id = Guid.Parse("9aa529ac-774f-4a26-b652-ba4b859b646d"), Type = TextBlockType.Text, Text = "If a target is in the light of a full moon, it also grows by one size if it were Medium or smaller. This increases the reach of a Medium or Tiny creature by 5 feet." };
        }


        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6f7986e1-167b-42c7-b2e8-6fb83090d98a"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6cc200aa-7b2f-407a-b4eb-de24633b8d9d"), Type = TextBlockType.Text, Text = "The temporary Hit Points increase to 10, the silver weakness to 10, and the damage dealt by the attacks to three dice." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("935f821f-909a-4474-a140-19e1411dbce7"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dfda5b97-9ec5-4d3c-8554-61319595a85f"), Type = TextBlockType.Text, Text = "The temporary Hit Points increase to 20, the silver weakness to 20, and the damage dealt by the attacks to four dice." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68781a1c-2b1b-4e10-9040-068e88c8a9be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 353
            };
        }
    }
}
