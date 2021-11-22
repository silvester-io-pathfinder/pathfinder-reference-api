using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StoneLance : Template
    {
        public static readonly Guid ID = Guid.Parse("0868b3ae-c053-4ad2-ae73-43af67b7aa55");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stone Lance",
                Level = 3,
                Range = "120 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cda33a95-4e99-4980-ae35-d68ba03b7ded"), Type = TextBlockType.Text, Text = "You conjure a jagged lance of stone and then launch it at a foe. Make a spell attack roll against the target. On a hit, you deal 6d6 piercing damage and the lance impales the creature, giving it a �10-foot circumstance penalty to its Speeds unless it Escapes. On a critical hit, if the creature is on the ground, the lance also embeds into the ground and immobilizes the creature until it Escapes. A creature that Escapes after being impaled takes 3 persistent bleed damage. When the spell ends, the lance crumbles into dirt, freeing the target if it hasn�t Escaped." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("31da264a-5841-4546-9618-706757d83bd1"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("34edb9ec-bc2d-45ca-9b7f-c95ec7c0f80c"), Type = TextBlockType.Text, Text = "Increase the damage by 2d6 and the persistent bleed damage for Escapes by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80b17e67-8a2e-4659-8be8-c5b904ffc46e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 201
            };
        }
    }
}