using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LayOnHands : Template
    {
        public static readonly Guid ID = Guid.Parse("5b36f993-0b0f-497f-8c23-33e3bf785a4e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lay on Hands",
                Level = 1,
                Range = "Touch.",
                Targets = "1 willing living creature or 1 undead creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7604721d-c2e0-4f7d-a0be-ff61e0e41f77"), Type = TextBlockType.Text, Text = "Your hands become infused with positive energy, healing a living creature or damaging an undead creature with a touch. If you use lay on hands on a willing living target, you restore 6 Hit Points; if the target is one of your allies, they also gain a +2 status bonus to AC for 1 round. Against an undead target, you deal 1d6 damage and it must attempt a basic Fortitude save; if it fails, it also takes a –2 status penalty to AC for 1 round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c11380a5-d6f1-4033-9f26-c9eca52fe3b1"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3fd4a51d-2470-4e5b-822b-1481b768f3b2"), Type = TextBlockType.Text, Text = "The amount of healing increases by 6, and the damage to an undead target increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5373bb9c-93d3-478f-b5be-c2148744b455"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c460afc9-8c71-45a3-a5e6-2b5fd8c5270c"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("2b865073-3e58-49bb-abe0-52a757fd0659"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("d4fcb5fd-ffb2-4d1b-9253-0ae1ee6f3e01"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("e0c096dd-d48d-414f-89b2-af9b42bd975a"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afc5fc5f-fc5d-4128-a6fd-cafafa92d88d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
