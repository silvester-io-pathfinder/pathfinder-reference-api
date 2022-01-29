using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StunningAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("d4502425-4306-445c-b2a8-1e03b798581f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stunning Appearance",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b1eb444-b0f4-4f50-9c09-a30a49f20fd7"), Type = TextBlockType.Text, Text = $"Your sudden appearance leaves your foe unable to respond. When you use {ToMarkdownLink<Models.Entities.Feat>("Startling Appearance", Feats.Instances.StartlingAppearance.ID)}, if your foe's level is equal to or lower than yours, they are also stunned 1 on a hit, or stunned 2 on a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("852b4b60-90e8-41c7-b7eb-a72cdcd38e5a"), Feats.Instances.StartlingAppearance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eafa18f6-0035-4964-b997-58adb3e02c80"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
