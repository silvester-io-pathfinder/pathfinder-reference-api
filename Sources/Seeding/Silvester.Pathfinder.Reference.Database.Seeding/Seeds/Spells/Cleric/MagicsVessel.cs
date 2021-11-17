using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicsVessel : Template
    {
        public static readonly Guid ID = Guid.Parse("8414f0b4-31c1-473e-a44b-cdb6c10a8ab0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic's Vessel",
                Level = 1,
                Range = "Touch",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Magic.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e6bff71-0f0a-457f-bf36-ddae1c077a56"), Type = TextBlockType.Text, Text = "A creature becomes a receptacle for pure magical energy sentby your deity. The target gains a +1 status bonus to saving throws. Each time you Cast a Spell from your spell slots, you automatically Sustain this Spell and grant its target resistance to damage from spells until the start of your next turn. This resistance is equal to the level of the spell you cast." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b057179-6d63-4f78-8820-9f6900427359"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
