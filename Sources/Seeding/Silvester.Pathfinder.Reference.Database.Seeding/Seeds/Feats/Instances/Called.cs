using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Called : Template
    {
        public static readonly Guid ID = Guid.Parse("76adc3f4-6436-4a65-a456-ee89c73ee773");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Called",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5fd712c9-05b8-4c6f-a3af-1c8114219ac3"), Type = TextBlockType.Text, Text = "You have heard the Call, and in constantly resisting that persistent demand, you&#39;ve developed a mental bulwark against effects that would target your mind. You gain a +1 circumstance bonus to Will saving throws against (trait: mental) effects. If you roll a success on your saving throw against a (trait: mental) effect that would make you controlled, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9f3ea39-b654-4e0a-b332-e76dbbd3e491"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
