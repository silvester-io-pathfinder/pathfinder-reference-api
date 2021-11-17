using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GolemDynamo : Template
    {
        public static readonly Guid ID = Guid.Parse("ffc2e066-78fe-4e27-92fe-bac426874250");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golem Dynamo",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a263321-e27f-450a-aef3-abaefb818258"), Type = TextBlockType.Text, Text = "~ Access: You are an automaton or are otherwise from the ancient Jistka Imperium." };
            yield return new TextBlock { Id = Guid.Parse("72a8cb0d-52b4-4d0a-ac1e-ff9e80aff6a5"), Type = TextBlockType.Text, Text = "You’ve learned the secrets of Jistkan golem prostheses, allowing you to incorporate golem components into your dynamo and gain a portion of their magic. You gain a +1 status bonus to saving throws against magic, and your dynamo (action: Strikes | Strike) become (trait: magical)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("619ef84f-dda5-4a90-a92d-204bfe8d8bb7"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2db9da28-2233-4244-8c24-2e8686bb8803"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
