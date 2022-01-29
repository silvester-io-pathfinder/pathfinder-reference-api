using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Squawk : Template
    {
        public static readonly Guid ID = Guid.Parse("4e59b1aa-7bc7-4302-8b0d-c59790bf7722");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Squawk!",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically fail a Deception, Diplomacy, or Intimidation check against a creature that doesn't have the tengu trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb07f972-7836-455f-9b07-4b8192474bd1"), Type = TextBlockType.Text, Text = $"You let out an awkward squawk, ruffle your feathers, or fake some other birdlike tic to cover up a social misstep or faux pas. You get a failure on the triggering check, rather than a critical failure. All creatures that witnessed you Squawk are temporarily immune for 24 hours." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a033385-a40d-4bf6-82bb-95323e99e67b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
