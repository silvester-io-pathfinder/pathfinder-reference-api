using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfGrowth : Template
    {
        public static readonly Guid ID = Guid.Parse("a6fbaed8-8578-43cf-bdbc-a5095c1f0828");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of Growth",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d833cd0b-2ecb-4e01-9d1a-f89b8fce0f9d"), Type = TextBlockType.Text, Text = "You can alter your exoskeleton’s size. You constantly gain the effects of (spell: enlarge). You can dismiss or resume these effects as an action, which has the (trait: concentrate) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("166add62-6af0-4f04-afed-f43d05d2a8d2"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
