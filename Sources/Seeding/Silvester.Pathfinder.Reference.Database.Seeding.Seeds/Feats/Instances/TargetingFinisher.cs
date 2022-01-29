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
    public class TargetingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("72a56563-6670-4064-bd15-1f6a91d97860");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Targeting Finisher",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("546de910-5f60-4734-b8dd-fa4aa15ca0e6"), Type = TextBlockType.Text, Text = $"Your attack harms and hinders your foe. Choose a particular part of your foe from the list below and {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you hit and damage the target, apply the effect corresponding to the chosen part. This hindrance lasts until the end of your next turn. On a critical hit, you also apply a lesser effect lasting for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("540cfce3-300f-4805-a2e9-c500ee406316"), Type = TextBlockType.Enumeration, Text = $" Arm (or another limb used for attacks, such as a tentacle): The target is enfeebled 2. On a critical hit, it is also enfeebled 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("4581faa3-2b24-4773-b489-7d3dc6c9d005"), Type = TextBlockType.Enumeration, Text = $" Head: The target is stupefied 2. On a critical hit, it is also stupefied 1 for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("09a282d5-da3f-45b0-aac7-5d7a6edfe593"), Type = TextBlockType.Enumeration, Text = $" Legs: The target takes a -10-foot status penalty to its Speeds. On a critical hit, it also takes a -5-foot status penalty to its Speeds for 1 minute." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be38d9b2-cc8a-41d1-bd3c-14836ed9462a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
