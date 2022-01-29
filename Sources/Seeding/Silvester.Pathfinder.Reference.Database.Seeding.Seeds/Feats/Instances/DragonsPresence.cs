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
    public class DragonsPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("a1519cc2-0214-4c87-be26-a8afa1f31900");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Presence",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b60fb22-1007-49de-adc3-3acf5a9c1326"), Type = TextBlockType.Text, Text = $"As a member of dragonkind, you project unflappable confidence (that collapses catastrophically against the deadliest foes). When you roll a success on a saving throw against a {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effect, you get a critical success instead. When you roll a failure against a {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effect, you get a critical failure instead." };
            yield return new TextBlock { Id = Guid.Parse("1e0adb85-e0ed-4be4-8021-1568a1444a00"), Type = TextBlockType.Text, Text = $"In addition, when you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} a foe of your level or lower, you gain a +1 circumstance bonus to the Intimidation check." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6756a862-c2a6-4443-94e5-c89062aea04d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
