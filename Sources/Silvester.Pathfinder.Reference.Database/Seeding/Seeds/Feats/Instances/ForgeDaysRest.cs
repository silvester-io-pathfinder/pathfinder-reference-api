using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForgeDaysRest : Template
    {
        public static readonly Guid ID = Guid.Parse("a1b76135-f85c-4781-b303-952052ee0503");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forge-Day's Rest",
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
            yield return new TextBlock { Id = Guid.Parse("26ca4afd-c8a4-4f6d-8445-7ba2743ad17c"), Type = TextBlockType.Text, Text = "~ Access: underground dwarf ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("7eca8c25-6762-47cf-9418-df09c9992620"), Type = TextBlockType.Text, Text = "Your unusual rest cycle allows you to recover faster. As long as you rest for 12 hours, you gain the effects of the (feat: Fast Recovery) general feat and you can go 20 hours without resting before becoming fatigued." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83c61597-7b39-43c1-9b4c-dc69a542aaf5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
