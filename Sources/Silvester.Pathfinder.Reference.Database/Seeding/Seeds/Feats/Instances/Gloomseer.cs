using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gloomseer : Template
    {
        public static readonly Guid ID = Guid.Parse("1476c9df-7d7d-44d6-8c06-c3971e54b186");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gloomseer",
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
            yield return new TextBlock { Id = Guid.Parse("5ed11e8f-8f1c-4d12-8e96-5cc3273e4ccf"), Type = TextBlockType.Text, Text = "Gloom holds few terrors for you, and the pall of darkness over Nidal has made you comfortable in dim light. You gain low-light vision." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("ebb1c77d-4663-4f4f-9137-04099e2b0089"), "Nidalese Ethnicity");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94f54f22-85ca-4a3a-8565-67d49643cf6b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
