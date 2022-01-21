using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InspireCompetence : Template
    {
        public static readonly Guid ID = Guid.Parse("49ba65ec-e814-4299-8d10-79e3f2f0d141");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inspire Competence",
                Level = 1,
                Range = "60 feet.",
                Duration = "1 round.",
                Targets = "1 ally.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2019fa3-b8ef-49d8-847f-e4931b28ef92"), Type = TextBlockType.Text, Text = "Your encouragement inspires your ally to succeed at a task. This counts as having taken sufficient preparatory actions to Aid your ally on a skill check of your choice, regardless of the circumstances. When you later use the Aid reaction, you can roll Performance instead of the normal skill check, and if you roll a failure, you get a success instead. If you are legendary in Performance, you automatically critically succeed." };
            yield return new TextBlock { Id = Guid.Parse("d617189f-c52e-4555-9712-4a2fd2f5d4fd"), Type = TextBlockType.Text, Text = "The GM might rule that you can't use this ability if the act of encouraging your ally would interfere with the skill check (such as a check to Sneak quietly or maintain a disguise)." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a19ccce6-a77d-4f01-ab3b-70d93ac57aff"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("714a422b-7999-422e-9029-dc987c06a2c1"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("0ad0be85-2168-4395-a75b-a9837cb14f62"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("8eeb6864-efeb-4dea-a8eb-c659e3cc15a0"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("66e9b201-551a-4b72-8be6-e7d7c04beed2"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("9593c152-69c3-47a6-bb08-e00ae789a67a"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ede9ae43-a5df-4ca6-89da-d23aa87a4ded"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("968190ee-cf56-4dc7-a08a-3bf9fbb3b92f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
