using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ShepherdOfSouls : Template
    {
        public static readonly Guid ID = Guid.Parse("d938da98-9d48-4d3c-a94e-f28c260fbe97");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shepherd of Souls",
                Level = 5,
                Range = "30 feet.",
                Trigger = "A living creature within 30 feet takes damage.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d82064ba-78ea-4c4f-a57c-c63351b0d821"), Type = TextBlockType.Text, Text = "You stay the hand of fate for one not yet destined to die, sacrificing some of your own vitality to heal them. You lose up to 15 Hit Points as a sacrifice, and the target reduces the damage by twice the number of Hit Points sacrificed. If this reduction exceeds the amount of damage, the target recovers Hit Points equal to the excess amount." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f516ab5d-9c57-460d-8e58-d4ae38df087c"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("eb3e32a3-1c6c-44da-84ed-16b4feeaa7ee"), Type = TextBlockType.Text, Text = "The maximum number of Hit Points you can sacrifice increases by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8aae269-29a5-40c4-9c37-a0fb9c04f152"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
