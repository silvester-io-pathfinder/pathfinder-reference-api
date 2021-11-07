using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FolktalesLore : Template
    {
        public static readonly Guid ID = Guid.Parse("c948e51d-58aa-47d4-ac46-f9e48cc289fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Folktales Lore",
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
            yield return new TextBlock { Id = Guid.Parse("89fcb699-b797-4f7c-b869-740770f5cd55"), Type = TextBlockType.Text, Text = "You can pull bits of wisdom from any tale. You become trained in Folktales Lore, a special Lore skill that can be used only to Recall Knowledge, but on any topic. If you fail a check to (action: Recall Knowledge) with Folktales Lore, you get the effects of the (feat: Dubious Knowledge) skill feat." };
            yield return new TextBlock { Id = Guid.Parse("c3e4d1c1-9788-466b-bd9f-161f45a4b7cd"), Type = TextBlockType.Text, Text = "If you are legendary in the Performance skill, you gain expert proficiency in Folktales Lore, but you can&#39;t increase your proficiency rank in Folktales Lore by any other means." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f5d41daf-a8e5-480f-a651-15e0a7628460"), Feats.Instances.FolkloristDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa867cb3-eda2-43d7-9ae3-92f957aca602"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
