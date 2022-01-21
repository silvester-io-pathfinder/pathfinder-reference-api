using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Spelunker : Template
    {
        public static readonly Guid ID = Guid.Parse("98007f49-8968-46d9-b503-1ca783196407");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spelunker",
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
            yield return new TextBlock { Id = Guid.Parse("b2113d7e-3d6d-401b-8b26-5bd5c193fb8c"), Type = TextBlockType.Text, Text = "Living underground, you have learned to find your way without landmarks or even solid ground. If you roll a success on an Survival check to (action: Sense Direction) or an Athletics check to (action: Climb), you get a critical success instead. You're not flat-footed when you attempt to (action: Climb)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("427dfb80-0fae-4bf6-9cc6-1472940b18ba"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
