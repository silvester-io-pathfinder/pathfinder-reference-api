using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProduceFlame : Template
    {
        public static readonly Guid ID = Guid.Parse("a6374c8f-0a48-42b8-80a9-5c9f39447e3b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Produce Flame",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1b5871a-4266-4915-82e7-37e51cf02b2e"), Type = TextBlockType.Text, Text = "A small ball of flame appears in the palm of your hand, and you lash out with it either in melee or at range. Make a spell attack roll against your target's AC. This is normally a ranged attack, but you can also make a melee attack against a creature in your unarmed reach. On a success, you deal 1d4 fire damage plus your spellcasting ability modifier. On a critical success, the target takes double damage and 1d4 persistent fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cee86192-e818-440d-94af-a838f38e6515"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("535412d6-3361-4caa-9bb5-470a2bc7fef2"), Type = TextBlockType.Text, Text = "Increase the damage by 1d4 and the persistent damage on a critical hit by 1d4." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("788a6344-8499-4e46-8810-be04e179a223"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("33a21aad-6a94-459d-9c27-39733bcfaf3a"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("3b7bedb6-752f-4abf-95ce-90164aba7f80"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("06034ac4-8509-482f-87c6-ccf738323e4a"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9800252-5fb5-47ff-a93b-958e8b22868d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
