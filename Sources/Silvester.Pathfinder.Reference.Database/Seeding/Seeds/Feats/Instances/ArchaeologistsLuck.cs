using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchaeologistsLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("b7170887-cf1b-4d2c-b507-de133fc51cfb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archaeologist's Luck",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a check against a trap, such as a Thievery check to Disable the trap or a Reflex save to avoid its effects.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a52469b1-f342-4617-bffa-945f557753ac"), Type = TextBlockType.Text, Text = "You are more than just skillful; your drive to find the secrets of the past manifests as a strange kind of luck. Reroll the failed check and use the new result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("65204459-70d5-4618-bf5a-76791264c328"), Feats.Instances.ArcheologistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f5e8723-c10b-4477-87bc-30d4ad10ebc4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
