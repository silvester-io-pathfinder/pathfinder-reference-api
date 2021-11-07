using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrategicAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("9153338b-2b2d-4782-ba2a-c109a8631f26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strategic Assessment",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("efd3d331-fda6-4475-a125-9fd71276e364"), Type = TextBlockType.Text, Text = "You learn your foes&#39; strengths and weaknesses by watching them move. When you critically hit a creature with a (action: Strike) on which you substituted your attack roll due to (action: Devising a Stratagem | Devise a Stratagem), the GM chooses one of the following pieces of information about the enemy to tell you." };
            yield return new TextBlock { Id = Guid.Parse("802d81fb-e0a2-43cf-8653-31bba1d2dd31"), Type = TextBlockType.Enumeration, Text = " : Which of the enemy&#39;s weaknesses is highest." };
            yield return new TextBlock { Id = Guid.Parse("a476193d-0db2-4c54-94a7-1c9415ecc048"), Type = TextBlockType.Enumeration, Text = " : Which of the enemy&#39;s resistances is highest." };
            yield return new TextBlock { Id = Guid.Parse("0a55cea9-665d-4400-92b4-2dbc1fbb2f1f"), Type = TextBlockType.Enumeration, Text = " : Which of the enemy&#39;s saving throws is lowest." };
            yield return new TextBlock { Id = Guid.Parse("97087a47-005f-4d8c-9477-a14b7b99a674"), Type = TextBlockType.Enumeration, Text = " : One immunity the enemy has." };
            yield return new TextBlock { Id = Guid.Parse("64a44f4a-15d7-4e34-9176-5a8c9f7522cc"), Type = TextBlockType.Text, Text = "The GM can choose deliberately or at random, but they can&#39;t choose information that doesn&#39;t apply (such as choosing an immunity for an enemy that has no immunities). This applies only the first time you critically hit a given creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34906dc4-2244-4d2d-bbda-e2326c07b40d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
