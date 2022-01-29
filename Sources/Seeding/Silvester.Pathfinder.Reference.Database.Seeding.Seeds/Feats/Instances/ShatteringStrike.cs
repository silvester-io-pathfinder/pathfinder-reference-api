using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShatteringStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("58112346-7b41-4df9-888d-419152fec11f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shattering Strike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An improvised weapon that you are wielding becomes broken as a result of a critical success on an Improvised Pummel.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9bc86378-2946-4424-9f9a-22faec1207b5"), Type = TextBlockType.Text, Text = $"The improvised weapon shatters, destroying it completely but dealing an additional 3d6 piercing damage to the creature you hit with the {ToMarkdownLink<Models.Entities.Feat>("Improvised Pummel", Feats.Instances.ImprovisedPummel.ID)}. This extra damage you apply on the critical hit doesn't double from the critical hit, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("188a1920-86e3-4c2f-a423-79d1f1c34f75"), Feats.Instances.ImprovisedPummel.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16cde26c-ed57-4d07-8d62-6cf748aeb80e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
