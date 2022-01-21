using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BarkAndTendril : Template
    {
        public static readonly Guid ID = Guid.Parse("8ba059f3-3b16-45be-aaae-31c258114c70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bark and Tendril",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06dab214-1949-47d8-a04f-4a0abec9b9e9"), Type = TextBlockType.Text, Text = $"You wield primal magic. You can cast {ToMarkdownLink<Models.Entities.Spell>("barkskin", Spells.Instances.Barkskin.ID)} and {ToMarkdownLink<Models.Entities.Spell>("entangle", Spells.Instances.Entangle.ID)} as 2nd-level primal innate spells once per day each." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0306d73b-5334-4549-8c5d-8de60f7cec73"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
