using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ComprehendLanguage : Template
    {
        public static readonly Guid ID = Guid.Parse("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Comprehend Language",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfb924de-ffd6-4655-a15a-c9b12e7fce35"), Type = Utilities.Text.TextBlockType.Text, Text = "The target can understand the meaning of a single language it is hearing or reading when you cast the spell. This doesn’t let it understand codes, language couched in metaphor, and the like (subject to GM discretion). If the target can hear multiple languages and knows that, it can choose which language to understand; otherwise, choose one of the languages randomly." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("d523848c-c447-477b-b8f3-48dc196055ef"), 
                Level = "3rd", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7ebed77a-cd19-4c03-ac0d-4cf9eaa438a3"), Type = Utilities.Text.TextBlockType.Text, Text = "The target can also speak the language." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("34a0a521-0496-4876-8e2e-1b7195af1f4b"),
                Level = "4th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fc636ff5-c742-41f6-8ba2-853c7c044221"), Type = Utilities.Text.TextBlockType.Text, Text = "You can target up to 10 creatures, and targets can also speak the language." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06db35da-06a9-4519-ac02-21b2ebf12245"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 325
            };
        }
    }
}
