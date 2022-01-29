using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MesmerizingGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("b2084fc6-f3ac-43c9-b100-c13c75807a5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mesmerizing Gaze",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ecb4b80-b599-452c-ab5a-815c0a415e56"), Type = TextBlockType.Text, Text = $"Eye contact can help you invade another creature's thoughts, as though you were peering directly through their eyes and into their mind. When you cast an {ToMarkdownLink<Models.Entities.Trait>("enchantment", Traits.Instances.Enchantment.ID)} spell that targets only one creature within 30 feet who can see you, you can gaze into the creature's eyes, causing the creature to take a –1 status penalty to their saving throw against your spell unless they choose to break the eye contact as a reaction. If they don't look away, you're fascinated with them until the end of your next turn as you maintain the eye contact. When you use Mesmerizing Gaze, the {ToMarkdownLink<Models.Entities.Action>("Avert Gaze", Actions.Instances.AvertGaze.ID)} action provides its bonus to saving throws against your spell, as the spell's effects have become connected to the eye contact." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00fd84e2-db1a-4883-bea1-12e4ed4c6e5d"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
