using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchaeologistsLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("265fe668-477b-4619-b186-39ba28955927");

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
            yield return new TextBlock { Id = Guid.Parse("f1cff7a1-7b94-40c1-9ef2-8d5d125a90fd"), Type = TextBlockType.Text, Text = "You are more than just skillful; your drive to find the secrets of the past manifests as a strange kind of luck. Reroll the failed check and use the new result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dfffcfdd-0702-4fd2-abcf-3a8b0875ae38"), Feats.Instances.ArchaeologistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("464f9c4e-7bf0-4ac9-93de-b5e644e6403e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
