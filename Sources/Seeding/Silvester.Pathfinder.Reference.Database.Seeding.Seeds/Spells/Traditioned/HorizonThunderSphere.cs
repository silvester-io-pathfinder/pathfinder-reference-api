using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HorizonThunderSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("3d72014c-5b9a-457b-b2f5-10f746f8726d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Horizon Thunder Sphere",
                Level = 1,
                Range = "Varies.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoOrThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c7d6d50-e6d0-477a-9ce7-fd64100b4d26"), Type = TextBlockType.Text, Text = "You gather magical energy into your palm, forming a concentrated ball of electricity that crackles and rumbles like impossibly distant thunder. Make a ranged spell attack roll against your target's AC. On a success, you deal 3d6 electricity damage. On a critical success, the target takes double damage and is dazzled for 1 round. The number of actions you spend when Casting this Spell determines the range and other parameters." };
            yield return new TextBlock { Id = Guid.Parse("75c36494-0e2a-46cd-b438-45f5357e102e"), Type = TextBlockType.Enumeration, Text = "[two-actions] (somatic, verbal) This spell has a range of 30 feet." };
            yield return new TextBlock { Id = Guid.Parse("37c0c351-3f02-46ce-9296-406380c4bc72"), Type = TextBlockType.Enumeration, Text = "[three-actions] (material, somatic, verbal) This spell has a range of 60 feet and deals half damage on a failure (but not a critical failure) as the electricity lashes out and jolts the target." };
            yield return new TextBlock { Id = Guid.Parse("2b8df5ad-4adc-4d2b-ab4e-fdca95cfe614"), Type = TextBlockType.Enumeration, Text = "Two Rounds If you spend 3 actions Casting the Spell, you can avoid finishing the spell and spend another 3 actions on your next turn to empower the spell even further. If you do, after attacking the target, whether you hit or miss, the ball of lightning explodes, dealing 2d6 electricity damage to all other creatures in a 10-foot emanation around the target (basic Reflex save). Additionally, you spark with electricity for 1 minute, dealing 1 electricity damage to creatures that Grab you or that hit you with an unarmed Strike or a non-reach melee weapon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fba97164-91de-4b8d-a31e-86a81f7589bd"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("464e2bed-441d-428f-86ed-69caa864f227"), Type = TextBlockType.Text, Text = "The initial damage on a hit, as well as the burst damage for two-round casting time, each increase by 2d6, and the damage creatures take if they Grapple or hit you while you're in your sparking state increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            builder.Add(Guid.Parse("bad753d7-17de-4a38-b018-f7b0811c0e42"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("3d589163-c583-45cc-91ae-d6eb8c59f9ca"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8c9e3119-db8c-47f0-928b-36860db57d6f"), Traits.Instances.Electricity.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe61446e-e268-46f0-a4ed-f68da755f2ae"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 110
            };
        }
    }
}
