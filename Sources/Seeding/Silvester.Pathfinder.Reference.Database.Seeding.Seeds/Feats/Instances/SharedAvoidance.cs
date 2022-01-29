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
    public class SharedAvoidance : Template
    {
        public static readonly Guid ID = Guid.Parse("adcafcbb-b63d-41f8-9971-3437b991f771");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Avoidance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f9d7912-ebb6-4077-8b2a-48ba0dc344b3"), Type = TextBlockType.Text, Text = $"You can project your premonitions of danger to your allies. When you use {ToMarkdownLink<Models.Entities.Feat>("Premonition of Avoidance", Feats.Instances.PremonitionOfAvoidance.ID)}, allies within 15 feet of you who are rolling the same saving throw against the same hazard also gain a +2 circumstance bonus to their saving throws." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7b99b05b-8931-4334-bc81-d8c3bfd43caf"), Feats.Instances.PremonitionOfAvoidance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("66528304-735f-4b98-b076-af2cce8ada62"), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b8e30a3-e2b3-41ba-b995-f330e7fb4b14"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
