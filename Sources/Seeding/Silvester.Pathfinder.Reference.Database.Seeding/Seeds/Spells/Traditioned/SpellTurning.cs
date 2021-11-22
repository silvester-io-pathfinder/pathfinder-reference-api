using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpellTurning : Template
    {
        public static readonly Guid ID = Guid.Parse("ec2778da-6da2-49ef-8b81-90aa386efaf8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spell Turning",
                Level = 7,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9317afe9-244c-4d18-b1be-571698f3fa71"), Type = TextBlockType.Text, Text = "This abjuration reflects spells cast at you back at their caster. When a spell targets you, you can spend a reaction to attempt to reflect it. This uses the rules for counteracting the spell, but if the spell is successfully counteracted, the effect is turned back on the caster. Whether or not the counteract attempt is successful, spell turning then ends. Spell turning can't affect spells that aren't targeted (such as area spells)." };
            yield return new TextBlock { Id = Guid.Parse("0f32ca73-1e49-474a-93f7-442f37d2551a"), Type = TextBlockType.Text, Text = "If spell turning reflects a spell back at a caster who is also under the effect of spell turning, their spell turning can attempt to reflect their own spell back at you again; if they do so, their counteract attempt automatically succeeds." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("854f60f9-9798-4d98-87a3-d4fa9ffe1e34"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
