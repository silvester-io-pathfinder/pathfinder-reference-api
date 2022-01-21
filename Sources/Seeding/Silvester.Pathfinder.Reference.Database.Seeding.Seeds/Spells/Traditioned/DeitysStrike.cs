using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DeitysStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e01cc0be-653f-4983-bdde-4c7b8ba09bc4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Deity's Strike",
                Level = 7,
                Range = "500 feet.",
                Requirements = "You have a deity.",
                Targets = "1 creature (see text).",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca72f989-c292-4cf6-a7bc-18efc3d939e9"), Type = TextBlockType.Text, Text = "A manifested version of your deity�s favored weapon appears in the air above and attacks the target, using your spell attack roll. On a hit, the weapon deals 7d12 force damage, or double damage on a critical hit." };
            yield return new TextBlock { Id = Guid.Parse("b4fedbed-b695-491a-9b0b-451d5cfbf112"), Type = TextBlockType.Text, Text = "After the attack, whether it succeeds or fails, divine energy bursts from the weapon in a shock wave. It emits in a 10-foot-wide, 30-foot-long line starting from the target and continuing in a direction you choose. Choose an alignment your deity has (chaotic, evil, good, or lawful). Your target and any other creatures within the area of the spell take 5d6 damage of the chosen alignment type, with a basic Reflex save. The spell gains the trait of the alignment you choose. If your deity is true neutral, the weapon doesn�t create a shock wave." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("aef1696a-46f7-40e5-a979-6f8613f1d0ab"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8055ccbc-e03c-4f75-b745-9b274b75b19e"), Type = TextBlockType.Text, Text = "The force damage increases by 1d12 and the alignment damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c46255b3-24e8-419c-98cc-1aac70412fb6"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("1af2e038-fa82-4c1c-9c95-70b822e7eac4"), Traits.Instances.Force.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baa9bf76-13f1-4f6c-a48d-6d9972421dbd"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 99
            };
        }
    }
}
