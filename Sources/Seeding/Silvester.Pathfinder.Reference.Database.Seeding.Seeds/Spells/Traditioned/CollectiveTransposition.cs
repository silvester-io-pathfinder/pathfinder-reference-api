using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CollectiveTransposition : Template
    {
        public static readonly Guid ID = Guid.Parse("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Collective Transposition",
                Level = 6,
                Area = "30-foot emanation",
                Targets = "Up to 2 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2861855c-e59b-403c-932b-0cdbe922a37f"), Type = Utilities.Text.TextBlockType.Text, Text = "You teleport the targets to new positions within the area. The creatures must each be able to fit in their new space, and their positions must be unoccupied, entirely within the area, and in your line of sight. Unwilling creatures can attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect 
            {
                Id = Guid.Parse("1220f4e1-8504-4702-9fcc-5318b162bb12"),
                CriticalSuccess = "The target can teleport if it wants, but it chooses the destination within range.",
                Success = "The target is unaffected.",
                Failure = "You teleport the target and choose its destination."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("8e38a5fc-f74d-4c0a-b653-4bc2c4610d9e"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b76a367e-5acb-4939-af0e-e955b770a0d0"), Type = Utilities.Text.TextBlockType.Text, Text = "The number of targets increases by 1." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8ca73214-e931-4315-ae7a-61b508c6ac60"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("20d57c4e-fc6f-46d2-9bef-bdbd65c497f2"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70f687a0-14a2-4190-9f19-5e43d304a32e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 324
            };
        }
    }
}
