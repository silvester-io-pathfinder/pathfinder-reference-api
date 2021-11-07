using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GolemDynamo : Template
    {
        public static readonly Guid ID = Guid.Parse("5d7631f7-836b-4967-a641-4c664c29f689");

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
            yield return new TextBlock { Id = Guid.Parse("1fc04456-7395-4608-acb8-bfd23648548e"), Type = TextBlockType.Text, Text = "~ Access: You are an automaton or are otherwise from the ancient Jistka Imperium." };
            yield return new TextBlock { Id = Guid.Parse("77315ff8-dad3-40cd-80c7-d1c1b8534674"), Type = TextBlockType.Text, Text = "You’ve learned the secrets of Jistkan golem prostheses, allowing you to incorporate golem components into your dynamo and gain a portion of their magic. You gain a +1 status bonus to saving throws against magic, and your dynamo (action: Strikes | Strike) become (trait: magical)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ec0b5c0e-65de-4668-88f3-dfb1d21c9ad3"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7a8919d-7020-411c-b7aa-245a810e6ae5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
