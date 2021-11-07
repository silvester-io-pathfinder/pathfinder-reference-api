using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnadiLore : Template
    {
        public static readonly Guid ID = Guid.Parse("e607dcad-33f8-41d6-87c8-50a6f97d2c65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anadi Lore",
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
            yield return new TextBlock { Id = Guid.Parse("5b72ad02-439e-493b-ac6b-78c785ed585a"), Type = TextBlockType.Text, Text = "You’ve learned how to provide for your community, be it through hard-earned sustenance or useful crafts. You gain the trained proficiency rank in Crafting and Survival. If you would automatically become trained in one of those skills (from your background or class, for example), you become trained in a skill of your choice. You also become trained in Anadi Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2650a72-fc2f-4c77-a8c3-f7aa641588d3"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
