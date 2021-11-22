using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ThunderingDominance : Template
    {
        public static readonly Guid ID = Guid.Parse("605718cd-1099-4b94-b84f-af27321d7d71");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Thundering Dominance",
                Level = 2,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "Your companion or eidolon.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35557c4c-2744-452e-acc1-39a0c65eb507"), Type = TextBlockType.Text, Text = "You shroud the target in a powerful predatory aura and amplify its vocalizations. It gains a +1 status bonus to Intimidation checks. Once during this spell�s duration, it can take the Thundering Roar action." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("3146d899-5719-4d0a-8bf6-b199aa8a472b"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Thundering Roar",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("09c40f51-0e68-454d-bfd9-4d968dbaf9ee"), Type = TextBlockType.Text, Text = "The target unleashes a powerful vocalization. Each enemy in a 10- foot emanation takes 4d8 sonic damage with a basic Will save against your spell DC. A creature that fails its Will save is also frightened 1." }
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
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e39781f-6557-4514-a8be-9c393f5dd5b1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 136
            };
        }
    }
}
