using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WavetouchedParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("775d7c7f-5452-475c-9a48-0c211a6eb841");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wavetouched Paragon",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the Bonuwat Wavetouched background (Lost Omens World Guide 94), you can take this feat at 1st level instead of 5th.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44ad8bf3-3d71-4093-bbf3-0c15df5974cb"), Type = TextBlockType.Text, Text = "~ Access: Bonuwat ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("08540b7a-e5bb-48a8-9dd5-94a2d7ad80fd"), Type = TextBlockType.Text, Text = "You have been blessed by the sea, granting you the ability to swim like a fish. You gain a 15-foot swim Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc16c7df-ac4c-4a81-a7db-105b16d58376"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
