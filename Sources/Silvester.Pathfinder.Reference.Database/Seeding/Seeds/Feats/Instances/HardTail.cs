using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HardTail : Template
    {
        public static readonly Guid ID = Guid.Parse("e664a3a6-e772-4eb5-a6a6-728dab42c195");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hard Tail",
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
            yield return new TextBlock { Id = Guid.Parse("0ca9090a-b58f-4248-ab29-b40e1cd8e48f"), Type = TextBlockType.Text, Text = "Your tail is much stronger than most, and you can lash out with it with the strength of a whip. You gain a tail unarmed attack that deals 1d6 bludgeoning damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("d2fc6530-63bb-4d31-b908-366d3f6dfa70"), Heritages.Instances.TailedGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d9d736d-f77f-42d2-9296-3255e77793c7"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
