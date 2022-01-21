using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class YoureMine : Template
    {
        public static readonly Guid ID = Guid.Parse("19e92d7b-67bf-4f5b-9085-1bef9545602e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "You're Mine",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0ecc4f7-2529-407b-b50a-2e1f41a1828e"), Type = TextBlockType.Text, Text = "You manipulate the target's emotions, potentially allowing you to control it for a brief instant. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("22f1bbab-46d9-4f52-8173-d313a4b8027e"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4f02b4bb-0e57-40a1-97b0-41a06c03e04a"), Type = TextBlockType.Text, Text = "On a failure, the target is controlled for 1 round. On a critical failure, the target is controlled for up to 1 minute; it receives a new Will save at the end of each of its turns, and on a success, the spell ends." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("078b2af8-41ba-4ada-933d-b8eb222e9b45"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stunned 1.",
                Failure = "On the target's next turn, it's stunned 1 and you partially control it, causing it to take a single action of your choice. If it has actions left, it can act normally.",
                CriticalFailure = "The target is controlled for 1 round."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("3f2d08da-ca7c-4cf5-ab05-bc96d4f004af"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e49a68fd-6b6a-47be-a664-86abd497603a"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("591422e1-e172-437b-a9b6-3b20b03869a8"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6b714b60-db2e-40c6-80ab-b2216f56d338"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("c7202fe9-89f3-4871-95e2-d4f49a60efde"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("e7911263-a15f-476d-8c6e-03e3a9c9a696"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbba9c0a-89cd-4b2a-bf9a-42a531242f8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
