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
    public class ArchaeologistsWarning : Template
    {
        public static readonly Guid ID = Guid.Parse("d21cb3a6-02a5-4d7a-8d7f-441482d8567c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archaeologist's Warning",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll a Perception, Society, or Thievery check for initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ab16abc-22b2-474a-b84f-8349facfab28"), Type = TextBlockType.Text, Text = $"You visually or audibly warn your companions of danger, granting them a +1 circumstance bonus to their initiative rolls. Depending on whether you use gestures or call out, this free action gains either the {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} or {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4360f32b-4939-40cd-b7f1-87a308ac1d09"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3a4928ac-2198-478a-b4f6-7ff1de80463a"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ffdf799-ff8d-4235-b711-caa07e205cb3"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
