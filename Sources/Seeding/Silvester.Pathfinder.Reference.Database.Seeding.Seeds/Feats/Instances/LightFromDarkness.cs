using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightFromDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("757d4708-585d-4da7-835b-bb9b395a7b3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Light from Darkness",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8272c9b-7316-45c0-b6b8-f6660e4edf9a"), Type = TextBlockType.Text, Text = $"You've battled the fiendish power within your nature and come out on top; whatever you decide to do with your life, for good or evil, will be your choice and your choice alone. This struggle has granted you powerful resistance against the divine. You gain a +1 circumstance bonus to all saving throws against {ToMarkdownLink<Models.Entities.Trait>("divine", Traits.Instances.Divine.ID)} effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("413a6907-b3a9-4728-953f-8572209b217a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
