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
    public class GruesomeStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("1b841f8b-7fe6-402b-8584-83488989e8b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gruesome Strike",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c9b2cb2-67b0-4a5a-be27-5930358a0de4"), Type = TextBlockType.Text, Text = $"Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the creature that triggered your champion's reaction. If you hit, the target takes double the extra damage from your reaction and must succeed at a Fortitude save against your class DC or be drained 1. Regardless of the result, the creature is temporarily immune to your Gruesome Strike for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("3aa73f49-616c-41a4-a6a1-540074b458d4"), Tenets.Instances.Evil.ID);
            builder.Manual(Guid.Parse("e2b11001-9014-4755-9174-3babc37f94ea"), "Champion's reaction that grants extra damage with your Strikes");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62723ab8-84ae-400d-b010-029046f99844"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
