using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("9a01c60c-c446-4b80-a644-2473a490f0a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Reflexes",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("204118a3-f60d-452f-ae67-4639f7bf9446"), Type = TextBlockType.Text, Text = "Your connection to your implements is so strong that you can use their reactive abilities almost by instinct. At the start of your turn, you gain an additional reaction, which you can use only for the reactions granted by your implements." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("e1ed75c3-6b67-4dd0-9b32-bc4e4efdbeaa"), "An implement that grants a reaction.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04b6580e-159d-47b6-964e-7da46302d626"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
