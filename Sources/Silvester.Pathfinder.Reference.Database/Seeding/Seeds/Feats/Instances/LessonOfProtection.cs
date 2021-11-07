using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfProtection : Template
    {
        public static readonly Guid ID = Guid.Parse("245b02f2-5d4a-4c7c-914e-6efca2c6957e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Protection",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d5356c0-e43f-4b58-aa93-4f4b486b8447"), Type = TextBlockType.Text, Text = "~ Lesson Type: Basic" };
            yield return new TextBlock { Id = Guid.Parse("9695cea4-0f93-4d0a-900e-3b20145ae732"), Type = TextBlockType.Text, Text = "You gain the (spell: blood ward) hex, and your familiar learns (spell: mage armor)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1feeef2c-7ab6-4225-aeec-e33763fbc008"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
