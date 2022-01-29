using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowyDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("5a1522b1-994d-46f0-a407-fd1e13b21d72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadowy Disguise",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ac7019c-b8eb-4204-9cd7-9310b4c1d453"), Type = TextBlockType.Text, Text = $"You wrap yourself in shadow to change your appearance. You can cast {ToMarkdownLink<Models.Entities.Spell>("illusory disguise", Spells.Instances.IllusoryDisguise.ID)} as a 1st-level occult innate spell once per day. This spell gains the {ToMarkdownLink<Models.Entities.Trait>("shadow", Traits.Instances.Shadow.ID)} trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b70a90a-74d3-4511-8f25-4210affbb342"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
