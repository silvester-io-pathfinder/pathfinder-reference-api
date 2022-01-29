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
    public class GuidingFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("fdb9ae57-4923-40fd-ad6e-ecbc5d729159");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guiding Finish",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f25b3dd-4d3f-44d3-9abb-99dae11bbece"), Type = TextBlockType.Text, Text = $"Using your weapon as a lever, you force your opponent to end up right where you want them. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you can move the target up to 10 feet into a space in your reach." };
            yield return new TextBlock { Id = Guid.Parse("1b27ce81-85e9-4124-98e7-259c45818a85"), Type = TextBlockType.Text, Text = $"You can move the target through your space during this movement. This follows the forced movement rules found on page 475. Your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} gains the following failure effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7114a536-6486-4121-ac4b-73c81f3cfe23"),
                
                
                Failure = "You can force the creature to move as you would on a success, but you can move the target only 5 feet.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc077a60-c549-46d1-9cd4-8d7bb7c8fb08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
