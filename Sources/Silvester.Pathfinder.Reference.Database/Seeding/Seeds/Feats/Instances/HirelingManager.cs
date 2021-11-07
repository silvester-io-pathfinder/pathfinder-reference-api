using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HirelingManager : Template
    {
        public static readonly Guid ID = Guid.Parse("e77827b0-9dc8-4099-a94f-7439525f2e24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hireling Manager",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03cd622c-3281-49f5-b213-2a0af7b64bfa"), Type = TextBlockType.Text, Text = "You are able to find and secure better labor than most. When securing a hireling for a service, that hireling gains a bonus applies to both trained and untrained hirelings and has no effect on the cost of the service or labor provided." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("6dfdd38f-3092-494b-857f-d1106a189ca6"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d84eca45-2097-4422-885f-2da358e56fd2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
