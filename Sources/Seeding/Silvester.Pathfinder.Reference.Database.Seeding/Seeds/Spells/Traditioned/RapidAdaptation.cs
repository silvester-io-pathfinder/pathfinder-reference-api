using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RapidAdaptation : Template
    {
        public static readonly Guid ID = Guid.Parse("d5c0a547-e29b-4206-a5e2-e132b1d11726");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rapid Adaptation",
                Level = 2,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "Your companion or eidolon.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ddd792d-a564-412b-a90d-3eb403ef48fe"), Type = TextBlockType.Text, Text = "You flood the target with energy from the terrain around it, compressing centuries of evolution into a single moment. The target gains one of the following natural adaptations based on the surrounding environment." };
            yield return new TextBlock { Id = Guid.Parse("e6f464da-cbd7-4071-b2b3-397ae8f61017"), Type = TextBlockType.Enumeration, Text = "Aquatic - The target gains a swim Speed equal to itsland Speed. If it already had a swim Speed, it gains a +10-foot status bonus to its swim Speed." };
            yield return new TextBlock { Id = Guid.Parse("919ad32b-0caa-49b6-9785-dd106d4103a8"), Type = TextBlockType.Enumeration, Text = "Arctic - The target isn't affected by severe or extreme cold, and when it rolls a success on an Acrobatics check to Balance on ice and snow, it gets a critical success instead." };
            yield return new TextBlock { Id = Guid.Parse("bcdfbeb7-d6c9-4d3a-a46d-2e08b6d67a8b"), Type = TextBlockType.Enumeration, Text = "Desert - The target isn't affected by severe or extreme heat, and when it rolls a success on an Acrobatics check to Balance on sand, it gets a critical success instead." };
            yield return new TextBlock { Id = Guid.Parse("f37e292c-98cd-4371-9298-ea41933c9fe5"), Type = TextBlockType.Enumeration, Text = "Forest - The target gains scent as an imprecise sense with a range of 30 feet." };
            yield return new TextBlock { Id = Guid.Parse("86b4942f-f22d-4476-9716-149c54d13871"), Type = TextBlockType.Enumeration, Text = "Mountain - The target isn't flat-footed when Climbing, and when it rolls a success on an Acrobatics check to Balance on rubble, it gets a critical success instead." };
            yield return new TextBlock { Id = Guid.Parse("0b37816a-17c7-444b-a404-64692a411c06"), Type = TextBlockType.Enumeration, Text = "Plains - The target gains a +10-foot status bonus to its land Speed." };
            yield return new TextBlock { Id = Guid.Parse("716c98b2-2dcb-4ac0-a93c-4e45dc252c95"), Type = TextBlockType.Enumeration, Text = "Underground - The target gains darkvision." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c8a11ef-740a-4971-b52c-f4ad36996cc5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 124
            };
        }
    }
}
