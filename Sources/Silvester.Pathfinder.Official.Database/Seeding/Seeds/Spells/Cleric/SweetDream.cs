using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SweetDream : Template
    {
        public static readonly Guid ID = Guid.Parse("90f111cc-f4a8-4c26-bfb1-a6ac79d98539");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sweet Dream",
                Level = 1,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "1 willing creature.",
                DomainId = Domains.Instances.Dreams.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5792b854-3225-4742-be9a-ecc77ef3d197"), Type = TextBlockType.Text, Text = "With soothing song or tales, you lull the target into an enchanting dream. When you cast the spell, the target falls unconscious if it wasn’t already. While unconscious, it experiences a dream of your choice. If it sleeps for at least 1 minute, it gains the benefit of the dream for the remainder of the spell’s duration." };
            yield return new TextBlock { Id = Guid.Parse("cbdc06b0-4b9c-4944-9202-5280e95021a8"), Type = TextBlockType.Enumeration, Text = "Dream of Insight - +1 status bonus to Intelligence-based skill checks." };
            yield return new TextBlock { Id = Guid.Parse("021979d7-33b0-462c-b375-28c0ec7dea46"), Type = TextBlockType.Enumeration, Text = "Dream of Glamour - +1 status bonus to Charisma-based skill checks." };
            yield return new TextBlock { Id = Guid.Parse("f521a944-b1d4-4353-974d-ca5a0fd9b7f3"), Type = TextBlockType.Enumeration, Text = "Dream of Voyaging - +5-foot status bonus to Speed." };
            yield return new TextBlock { Id = Guid.Parse("1a8ce36f-d599-4b3c-8190-f01078a4173e"), Type = TextBlockType.Text, Text = "If you Cast this Spell again, the effects of any previous sweet dream you cast end." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sleep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5fab4ae-e1de-4384-b5f4-73f6ebe3d6c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
