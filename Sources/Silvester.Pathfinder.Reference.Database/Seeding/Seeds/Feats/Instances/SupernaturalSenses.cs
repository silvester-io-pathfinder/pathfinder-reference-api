using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SupernaturalSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("3dadc72a-29de-41a0-88cb-8ed8ad60ee37");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Supernatural Senses",
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
            yield return new TextBlock { Id = Guid.Parse("0e3a5329-9cb0-4a00-a6a4-c1ac6d583dcf"), Type = TextBlockType.Text, Text = "Your scent is preternaturally sharp, and you can always rely on your sense of smell to help guide you when your vision is compromised. When you target a concealed or hidden opponent while you are raging, you reduce the DC of the flat check to 3 for a concealed target or to 9 for a hidden one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b87aa15d-145c-494f-b398-5d6c066ae2ba"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("3489924e-91cd-4a99-bbf7-26cd60d49e36"), Feats.Instances.AcuteScent.ID);
                or.HaveSpecificSense(Guid.Parse("cf6f2739-3c7c-48d9-8bf6-45bc1589c6de"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Precise.ID);
                or.HaveSpecificSense(Guid.Parse("9158d438-80d5-4da7-99a2-b295182c28bb"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("756b7173-64eb-4695-b015-b9cc330f259c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
