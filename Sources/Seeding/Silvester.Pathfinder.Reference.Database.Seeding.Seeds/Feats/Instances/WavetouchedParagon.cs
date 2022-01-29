using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WavetouchedParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("74ae996f-1c0d-4aac-95c4-30b833eac98f");

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
            yield return new TextBlock { Id = Guid.Parse("707ca441-f831-4fc3-83f4-a0a4f90f7747"), Type = TextBlockType.Text, Text = $"~ Access: Bonuwat ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("14705f2b-7156-4e9e-8e51-7c7b186de4cf"), Type = TextBlockType.Text, Text = $"You have been blessed by the sea, granting you the ability to swim like a fish. You gain a 15-foot swim Speed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d0d52a21-8373-4181-b6ac-b5057c564603"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecfe8c15-d8a3-4793-822d-c5da7edd986a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
