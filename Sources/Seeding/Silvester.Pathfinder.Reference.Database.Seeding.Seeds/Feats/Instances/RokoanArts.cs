using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RokoanArts : Template
    {
        public static readonly Guid ID = Guid.Parse("d632b7a5-9d3c-457a-94e7-1798c7e38ca1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rokoan Arts",
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
            yield return new TextBlock { Id = Guid.Parse("ff6e5411-bb3a-4968-8d03-4c6a06ecfac8"), Type = TextBlockType.Text, Text = $"Ancestral spirits have begun to bond themselves to you, granting you powers characteristic of a rokoa. You can cast {ToMarkdownLink<Models.Entities.Spell>("speak with animals", Spells.Instances.SpeakWithAnimals.ID)} and {ToMarkdownLink<Models.Entities.Spell>("status", Spells.Instances.Status.ID)} as primal innate spells once per day each." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f387d5e-9d7b-433d-90f1-f799eddf15ee"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
