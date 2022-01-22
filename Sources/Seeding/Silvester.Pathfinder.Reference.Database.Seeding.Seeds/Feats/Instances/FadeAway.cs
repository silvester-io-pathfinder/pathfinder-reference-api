using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FadeAway : Template
    {
        public static readonly Guid ID = Guid.Parse("ff91a900-b63f-4446-97b7-88e3dc98bda0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fade Away",
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
            yield return new TextBlock { Id = Guid.Parse("72fafa1c-8b54-4d62-b5f0-ef63d0253234"), Type = TextBlockType.Text, Text = $"Your ability to blend into the background allows you to fade away entirely or appear innocuous even to magical effects. You gain {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} and {ToMarkdownLink<Models.Entities.Spell>("misdirection", Spells.Instances.Misdirection.ID)} as 2nd-level innate occult spells. You can target only yourself with {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)}, and you must be the primary target of {ToMarkdownLink<Models.Entities.Spell>("misdirection", Spells.Instances.Misdirection.ID)}. You can cast each spell once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c70a2c6b-c21b-457c-b82d-f45184ee9681"), Feats.Instances.EasilyDismissed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d29f764-fcf5-4c9f-8577-386dd4dd9e30"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
