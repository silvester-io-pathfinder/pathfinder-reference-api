using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c822df53-051e-437c-9c6d-7b5a2e759811"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c2c59f44-8071-410c-b8d4-f8fc9422e60c"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("153b1b48-0583-42de-9301-8943767f2c94"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("0fb8633b-4d76-459d-bd1f-75357f79a3df"), Traits.Instances.Sonic.ID);
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
