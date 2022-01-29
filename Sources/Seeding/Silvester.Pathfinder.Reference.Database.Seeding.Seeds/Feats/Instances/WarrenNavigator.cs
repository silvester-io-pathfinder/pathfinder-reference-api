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
    public class WarrenNavigator : Template
    {
        public static readonly Guid ID = Guid.Parse("38bf1e85-2cb2-430b-a873-e1a454942957");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warren Navigator",
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
            yield return new TextBlock { Id = Guid.Parse("d5efd5c9-050e-48b7-a8a1-945f2de10918"), Type = TextBlockType.Text, Text = $"You're particularly good at solving mazes and navigating twists and turns. You gain the trained proficiency rank in Survival. If you would automatically become trained in Survival (from your background or class, for example), you become trained in another skill of your choice. When you {ToMarkdownLink<Models.Entities.SkillAction>("Sense Direction", SkillActions.Instances.SenseDirection.ID)} or attempt a roll against a {ToMarkdownLink<Models.Entities.Spell>("maze", Spells.Instances.Maze.ID)} spell, you get a result one degree of success better than you rolled. You don't take a penalty to {ToMarkdownLink<Models.Entities.SkillAction>("Sense Direction", SkillActions.Instances.SenseDirection.ID)} when you lack a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("compass", Items.AdventuringGears.Instances.Compass.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ee80795-5a15-437a-bd32-0881254ab43b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
