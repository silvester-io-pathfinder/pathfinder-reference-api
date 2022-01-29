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
    public class BeastSpeaker : Template
    {
        public static readonly Guid ID = Guid.Parse("bf807ecf-b6ea-4d1b-937c-1ced13ca2285");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Speaker",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46341005-da4a-4b22-a75d-18afafcf2323"), Type = TextBlockType.Text, Text = $"You constantly have the effects of {ToMarkdownLink<Models.Entities.Spell>("speak with animals", Spells.Instances.SpeakWithAnimals.ID)} as a 2nd-level innate primal spell. You gain a +2 circumstance bonus to Diplomacy checks to make a {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} of animals while this spell is active." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("21501f95-39e1-40bd-9485-ce6e43d2075b"), Feats.Instances.AnimalTrainerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("47745f42-3618-4a11-9ef4-c417aa766bdf"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a47dff6e-d96b-403b-b28d-8217d1446270"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
