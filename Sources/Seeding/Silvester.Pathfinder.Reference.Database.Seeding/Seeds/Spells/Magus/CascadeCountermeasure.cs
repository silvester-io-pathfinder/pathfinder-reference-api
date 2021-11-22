using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CascadeCountermeasure : Template
    {
        public static readonly Guid ID = Guid.Parse("0e7ecc46-62ca-414d-adff-170310682528");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cascade Countermeasure",
                Level = 3,
                Requirements = "You're benefiting from Arcane Cascade.",
                Duration = "Until the Arcane Cascade stance ends.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Magus.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("daab0647-75bf-4267-8e0d-c5d4abacda47"), Type = TextBlockType.Text, Text = "You quickly adjust your Arcane Cascade to offer magical protection. You gain resistance 5 against damage from spells. As normal, using Arcane Cascade again means you�ve ended the stance, and the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("31982f59-1858-4804-a94e-e7cd2998fa8f"),
                Level = "+3",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e27099a6-6204-413a-85b6-dd814bf6e7c0"), Type = TextBlockType.Text, Text = "The resistance increases by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Magus.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cecf0825-a596-458e-b544-86934a8d21bb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
