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
    public class SilencingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("52c22e90-6054-46fd-ba43-623c2eafa39b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silencing Strike",
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
            yield return new TextBlock { Id = Guid.Parse("8a30f3b6-da6b-42e9-8006-299a252e7827"), Type = TextBlockType.Text, Text = $"A quick strike to the face or mouth silences your opponent. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a foe. The foe must succeed at a Fortitude save against your class DC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("4116ff11-b12f-409f-8080-bf1f94d58bcf"),
                
                Success = "The target is unaffected.",
                Failure = "The target is dazed and can barely vocalize. It's stunned 1 and its speech is raspy and hard to understand. It must succeed at a DC 11 flat check to use (trait: linguistic) actions or supply verbal spellcasting components until the end of its next turn.",
                CriticalFailure = "As failure, but the creature is stunned 3 instead of stunned 1.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fac486fc-cb52-4171-bf99-1880e0a6fce5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
