using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ThunderousStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("c6444b48-4d07-4b5d-8a8a-78382f7c57ac");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Thunderous Strike",
                Level = 1,
                Requirements = "you're wielding a melee weapon in two hands.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Magus.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c45e2107-079e-4cc1-af8b-e1ea10c6ad96"), Type = TextBlockType.Text, Text = "You swing your massive weapon, creating a wave of sonic vibrations that topples creatures. Make a melee Strike with your two-handed weapon. Each creature in a 15-foot cone from you must attempt a basic Fortitude save against your spell DC or take 2 sonic damage. On a critical failure, the creature is knocked prone. The target of your Strike must be within the cone or the effect fails." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c5dc661f-0c2e-4a88-9496-e726cfc80d7c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("83a630b4-18cd-4790-a099-cddd9cc814d3"), Type = TextBlockType.Text, Text = "The damage increases by 1." }
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magus.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58331a73-ccf9-43dc-9d7c-7913c05f9695"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
