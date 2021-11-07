using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuliJann : Template
    {
        public static readonly Guid ID = Guid.Parse("19772dc4-d6ff-49f1-b72c-df81bb3f2c05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Suli-Jann",
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
            yield return new TextBlock { Id = Guid.Parse("766ad619-39f1-4401-9123-86812de4a7f1"), Type = TextBlockType.Text, Text = "Your elemental ancestor was a janni, genies that walk the mortal world and embody all four elements together. You inherited a janni’s nature as a wanderer and ability to survive in many types of environment, from the hottest desert to the coldest tundra. You gain the trained proficiency rank in Survival. If you would automatically become trained in Survival (from your background or class, for example), you instead become trained in a skill of your choice. You gain the (feat: Forager) skill feat as a bonus feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a45d341f-ea2d-42f5-91eb-32a0aae8205b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
