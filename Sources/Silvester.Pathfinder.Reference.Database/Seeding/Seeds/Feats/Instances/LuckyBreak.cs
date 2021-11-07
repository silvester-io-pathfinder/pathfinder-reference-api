using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LuckyBreak : Template
    {
        public static readonly Guid ID = Guid.Parse("cee6b547-f473-4da9-8ec3-f6b4dc70fc82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lucky Break",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd80ea29-31f4-4a67-b651-92c63462b3a8"), Type = TextBlockType.Text, Text = "You catch yourself as you make a mistake. You can trigger (feat: Cat’s Luck) when you fail or critically fail on an Athletics or Acrobatics skill check, in addition to its normal trigger. When you do, you reroll the triggering skill check and use the better result. This still counts against (feat: Cat&#39;s Luck)&#39;s frequency, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e48e32b-13e7-4b5e-aba5-863e0fb5019a"), Feats.Instances.CatsLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d574eab0-9c2c-448c-982b-d352ea609362"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
