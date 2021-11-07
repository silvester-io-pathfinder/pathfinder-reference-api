using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastDynamoHowl : Template
    {
        public static readonly Guid ID = Guid.Parse("a1f1ed9c-e1c5-4b8b-8f23-8168ac38ad24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Dynamo Howl",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2e46571-be21-41e4-8072-0677011b1553"), Type = TextBlockType.Text, Text = "~ Access: You are from Arcadia." };
            yield return new TextBlock { Id = Guid.Parse("d4f01a7b-44fa-40c1-920f-bd1188b0b55f"), Type = TextBlockType.Text, Text = "You’ve incorporated beast tech from Arcadia into your dynamo, adding in components from various terrifying creatures to enhance your prosthesis’s capabilities. The beast parts can unleash a disturbing howl as you make a powerful attack with your dynamo. Attempt a single Intimidation check to (action: Demoralize) each enemy within 30 feet; you don’t take a penalty when you attempt to (action: Demoralize) a creature that doesn’t understand your language. Then, make a dynamo (action: Strike). Reduce the operational time of your sterling dynamo by 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e6c00a01-cbdb-42f1-83c0-6d4792471a3c"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1caab6e1-6863-49b1-9624-c8e3c385fbe5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
