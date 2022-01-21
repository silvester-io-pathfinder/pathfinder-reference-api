using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("f47d119a-c0f3-4dfc-a496-6c30f004ef27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb40e398-faaa-4b44-b8a0-9c724529b4df"), Type = TextBlockType.Text, Text = $"You've practiced a technique for mixing alchemical bombs with your loaded shot. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to retrieve the bomb (if it's not already in your hand) and pour its contents onto your ammunition, consuming the bomb. Next, {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your firearm. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals damage of the same type as the bomb (for instance, fire damage for alchemist's fire), and it deals an additional 1d6 persistent damage of the same type as the bomb. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is a failure, you take 1d6 damage of the same type as the bomb you used, and the firearm misfires." };
            yield return new TextBlock { Id = Guid.Parse("eb861c60-4cea-428d-9b3a-ea45b7b5f1f2"), Type = TextBlockType.Text, Text = $"The persistent damage increases to 2d6 if the bomb is 11th level or higher, or 3d6 if it's 17th level or higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("338f9b55-cff5-499e-ac40-d5faa39d39d9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
