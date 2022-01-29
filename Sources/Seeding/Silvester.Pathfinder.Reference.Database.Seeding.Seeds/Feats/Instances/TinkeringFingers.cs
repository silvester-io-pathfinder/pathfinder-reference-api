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
    public class TinkeringFingers : Template
    {
        public static readonly Guid ID = Guid.Parse("18e13492-2dbc-4fb2-b6d2-07c978c7fa63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tinkering Fingers",
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
            yield return new TextBlock { Id = Guid.Parse("e9a19eb4-990b-4936-a6f6-284adf3212f0"), Type = TextBlockType.Text, Text = $"You're good with your hands and can quickly improvise a fix for broken or damaged equipment. You're trained in Crafting. If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. You can {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} an item without using a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("repair kit", Items.AdventuringGears.Instances.RepairKit.ID)} without taking the -2 circumstance penalty, improvising tools from whatever you have at hand." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca9445a9-f407-46c8-b30c-1280c76eb8c4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
