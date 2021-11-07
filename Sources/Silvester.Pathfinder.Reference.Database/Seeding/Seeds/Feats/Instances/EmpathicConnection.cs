using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmpathicConnection : Template
    {
        public static readonly Guid ID = Guid.Parse("5e834fc6-b5d9-45ec-b7bc-925257345764");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Empathic Connection",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet benefits from an emotion effect.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("354afa4e-95ac-45c6-9190-62d31dfc8aa4"), Type = TextBlockType.Text, Text = "Your sensitivity to your allies’ emotions allows you to benefit from some of the same effects they do. Choose one of the following two benefits." };
            yield return new TextBlock { Id = Guid.Parse("473494b0-b45a-495c-a842-9339219fdee3"), Type = TextBlockType.Enumeration, Text = " : If the ally regained Hit Points due to the triggering effect, you gain half these Hit Points as temporary Hit Points that last until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("bd5d3f05-7736-4393-a174-9f3b057bebd5"), Type = TextBlockType.Enumeration, Text = " : If the ally gained a status bonus to a type of save or other check due to the triggering effect, you gain the same bonus. This benefit ends at the end of your next turn if it hasn’t already ended before then due to its normal limitations or duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74e9cc34-67fa-4337-82c9-65522f052461"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
