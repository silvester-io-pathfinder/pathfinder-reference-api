using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergizedFont : Template
    {
        public static readonly Guid ID = Guid.Parse("484dead2-875e-417c-a810-de593d5f1e19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energized Font",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7a2f258-a129-41d2-81e2-c90248612307"), Type = TextBlockType.Text, Text = "The magic within you provides increased energy you can use to focus. You regain 1 Focus Point, up to your usual maximum." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("168a1176-8e0a-40e3-ac25-9305566f6bbc"));
            builder.Manual(Guid.Parse("a98e139b-485b-4653-aef1-13f70291e93c"), "At least one innate spell from a gonome heritage or ancestry feat that shares a tradition with at least one of your focus spells.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("117308f8-f2c6-403f-b98b-d27bbc26915e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
