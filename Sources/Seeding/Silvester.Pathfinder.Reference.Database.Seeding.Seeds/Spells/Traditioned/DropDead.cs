using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DropDead : Template
    {
        public static readonly Guid ID = Guid.Parse("6d11a1a1-ff34-468a-8850-caa78f305429");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Drop Dead",
                Level = 5,
                Range = "120 feet.",
                Duration = "Sustained up to 1 minute.",
                Targets = "1 creature.",
                Trigger = "A creature within range is hit by an attack from an enemy.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec852bcb-fe33-43d3-8de8-e07b8d889f7c"), Type = TextBlockType.Text, Text = "The target appears to fall down dead, though it actually turns invisible. Its illusory corpse remains where it fell, complete with a believable fatal wound. This illusion looks and feels like a dead body. If the target's death seems absurd—for instance, a barbarian at full health appears to be slain by 2 damage—the GM can grant the attacker an immediate Perception check to disbelieve the illusion. If the target uses hostile actions, the spell ends. This ends the entire spell, so the illusory corpse disappears too." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2821d094-a0eb-4a32-b24c-e19bb40b0c7f"), 
                Level = "tth",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b799f023-a21c-4c0c-8b97-7f5207234770"), Type = TextBlockType.Text, Text = "The spell doesn't end if the target uses hostile actions." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ee8d73a7-ee10-4da8-a037-122a51b5aaed"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5b78b8b1-30fb-4d35-b509-d04e0beef018"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("446dca2f-d0a2-4099-b6ec-60839c41c700"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c1e0356-25a7-4243-ba04-750d0be166a3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 333
            };
        }
    }
}
