using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PiercingCritical : Template
    {
        public static readonly Guid ID = Guid.Parse("374351ba-4e98-4cc5-9821-0bb2d3c7187c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Piercing Critical",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("90287073-ebab-4330-89aa-2a981177cad6"), Type = TextBlockType.Text, Text = "Your attacks with your preferred weapons deal especially devastating wounds. When you (action: Strike) with a firearm or crossbow for which you have legendary proficiency, you critically succeed if you roll a 19 on the die, as long as that result is a success." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0849f2d0-5257-4f09-8398-8cc99105a0eb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
