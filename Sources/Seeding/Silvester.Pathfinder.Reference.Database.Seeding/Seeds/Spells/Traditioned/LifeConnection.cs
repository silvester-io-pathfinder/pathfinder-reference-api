using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeConnection : Template
    {
        public static readonly Guid ID = Guid.Parse("116c26f7-d869-4ebb-9844-6371cb87a660");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life Connection",
                Level = 3,
                Range = "Touch.",
                Duration = "24 hours.",
                Targets = "1 living creature.",
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5de6b0b-8fa2-443e-854c-a9a8b053493a"), Type = TextBlockType.Text, Text = "When you cast this spell, you place a failsafe deep within the life force of the target. You can sense when the target takes damage, provided you�re within 1 mile of one another. A creature can be part of no more than one life connection simultaneously. When the spell is complete, you gain the Defend Life reaction; once you use the reaction, the spell ends." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("b434077f-0ce7-4daa-a65b-9cbc61cb688a"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Defend Life",
                Requirements = "You�re within 1 mile of the target",
                Trigger = "The target takes damage.",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("f6792e86-4047-48b5-8522-8f1bf492c75b"), Type = TextBlockType.Text, Text = "After calculating the amount of damage the target would take (applying weaknesses, resistances, and the like), you lose an equal number of Hit Points, and the target doesn�t take any of the damage. You can�t reduce the amount of Hit Points you lose in this way. The target still takes any effects that would come with the damage, however, such as the venom on a viper�s fangs Strike." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Contingency.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bac3afc8-69b8-4e87-80af-28ca2a9fd913"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 113
            };
        }
    }
}
