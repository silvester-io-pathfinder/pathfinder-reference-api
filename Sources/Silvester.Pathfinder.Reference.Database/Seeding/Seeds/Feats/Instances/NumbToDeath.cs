using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NumbToDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("9aa698f2-07a6-45b2-8842-5f7d9f9dd2da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Numb to Death",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92a06f81-6bab-46af-a822-02fc3ba66dda"), Type = TextBlockType.Text, Text = "Your past has left you numb to death’s call. The first time each day that you regain Hit Points while you are dying, you regain additional Hit Points equal to your level, and you neither gain the wounded condition nor increase the value of this condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0e077352-d967-4af0-9285-0b534df66c21"), Feats.Instances.Diehard.ID);
            builder.Manual(Guid.Parse("7224aa48-b6cf-4210-9d3a-884fd7c91435"), "You have died at least once.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c913ed2d-7eee-4709-9c5d-b99995378582"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
