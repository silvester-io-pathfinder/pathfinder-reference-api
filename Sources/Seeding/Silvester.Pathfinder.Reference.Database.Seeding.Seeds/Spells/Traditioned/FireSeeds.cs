using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FireSeeds : Template
    {
        public static readonly Guid ID = Guid.Parse("81520f05-c7b8-457c-9396-7546f8079826");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fire Seeds",
                Level = 6,
                Duration = "1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d21d819-56fe-41c7-a0be-4a71db93456c"), Type = TextBlockType.Text, Text = "Four acorns grow in your hand, their shells streaked with pulsing red and orange patterns. You or anyone else who has one of the acorns can toss it up to 30 feet with an Interact action. It explodes in a 5-foot burst, dealing 4d6 fire damage. The save uses your spell DC, even if someone else throws the acorn." };
            yield return new TextBlock { Id = Guid.Parse("ed0082a2-cf17-4ef4-b15c-bfff7da31567"), Type = TextBlockType.Text, Text = "Flames continue to burn on the ground in the burst for 1 minute, dealing 2d6 fire damage to any creature that enters the flames or ends its turn within them. A creature can take damage from the continuing flames only once per round, even if it's in overlapping areas of fire created by different acorns." };
            yield return new TextBlock { Id = Guid.Parse("8bcade86-bae2-4100-8b26-a4720c4746ba"), Type = TextBlockType.Text, Text = "When the spell ends, any remaining acorns rot and turn to ordinary soil." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bceae8b1-eb8e-429a-870a-8014588d56b2"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f6472638-75c8-40dc-86ee-3979c4ca118d"), Type = TextBlockType.Text, Text = "The burst's damage increases to 5d6, and the continuing flames damage increases to 3d6." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b50c8ebc-1941-4de4-b1f4-c0a578de0698"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("10a397f6-ce42-43e5-9afc-8076db1e9c1e"), Type = TextBlockType.Text, Text = "The burst's damage increases to 6d6, and the continuing flames damage increases to 3d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("01b0a741-41b6-4d01-9498-fc5f3a5b1a47"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("97bc7f56-7801-45ab-837a-a2c690e8a432"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("982021c8-9c00-40d9-8083-4d662a3dd147"), Traits.Instances.Plant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1da6871-9504-469e-a851-2611f5beec2c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 338
            };
        }
    }
}
