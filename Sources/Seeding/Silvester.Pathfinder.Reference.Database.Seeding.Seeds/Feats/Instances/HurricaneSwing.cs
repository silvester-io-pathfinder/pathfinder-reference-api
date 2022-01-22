using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HurricaneSwing : Template
    {
        public static readonly Guid ID = Guid.Parse("eda5da4f-13fe-4f30-b39f-060205fd92fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hurricane Swing",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically hit a foe with a Strike with a slashing weapon.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa2d2122-2070-4890-b15e-c095d0fe6246"), Type = TextBlockType.Text, Text = $"Choose either {ToMarkdownLink<Models.Entities.Spell>("lightning bolt", Spells.Instances.LightningBolt.ID)} or {ToMarkdownLink<Models.Entities.Spell>("gust of wind", Spells.Instances.GustOfWind.ID)}. You {ToMarkdownLink<Models.Entities.Rule>("Cast the chosen Spell", Rules.Instances.CastASpell.ID)} as a 6th-level primal innate spell in the direction of the target of the triggering action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2717bf0d-6ba6-439e-87ab-bbcdbed69092"), Feats.Instances.StormsLash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61ec4029-7169-4a98-b601-d3bbfd0f08aa"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
