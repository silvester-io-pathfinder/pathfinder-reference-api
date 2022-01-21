using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Replicate : Template
    {
        public static readonly Guid ID = Guid.Parse("a01012e0-e249-4347-822e-4a70457af378");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Replicate",
                Level = 4,
                Range = "60 feet.",
                Duration = "Sustained.",
                Targets = "1 willing or unconscious creature of 8th level or lower.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1db3209a-c80e-45be-bc02-5b4631d8a18e"), Type = TextBlockType.Text, Text = "You create an illusory magical double that physically looks and behaves very similarly to the target. This double is limited to moving, Interacting, speaking short sentences, and other similar basic tasks. It is unable to cast spells, attack, or use any complex skills." };
            yield return new TextBlock { Id = Guid.Parse("4bacb86d-d646-4314-a1d7-9e41eeb0d997"), Type = TextBlockType.Text, Text = "The illusory duplicate is your minion. You can issue new commands to the double as part of Sustaining the Spell. You can command the duplicate telepathically as long as the spell lasts, provided it�s within 1 mile of you. You can switch between using your own senses and the duplicate�s senses with a single action, which has the concentrate trait. The illusory duplicate has the same statistics as the original creature, except it doesn�t have any of the original�s item bonuses, and it has one quarter of the original�s Hit Points. If the double�s Hit Points are reduced to 0, the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7abffba4-ced2-4a3d-becc-b540870eaf49"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b8da3fb3-215e-4ffc-bd2a-5b4be423ae2b"), Type = TextBlockType.Text, Text = "The maximum level of the target increases by 2." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("75827773-acc8-4bd6-8f35-e7ec587ea930"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("1db2dd96-42f2-4a07-a2e8-7bfe6cd915c6"), Traits.Instances.Shadow.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f23e416-ca04-4fe3-a0ba-07ff5ef08728"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 125
            };
        }
    }
}
