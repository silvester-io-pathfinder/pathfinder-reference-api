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
    public class SeekerOfTruths : Template
    {
        public static readonly Guid ID = Guid.Parse("526d3b89-4fd8-4327-9148-95a8ff1dee1f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seeker of Truths",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat up to three times, selecting a different domain each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca221bc0-0bb5-4db0-a211-d7cd8126de03"), Type = TextBlockType.Text, Text = $"Your devotion to discovering and hoarding abstruse truths borders on the fanatical, and you can bring this devotion to bear. You gain the cleric's {ToMarkdownLink<Models.Entities.Feat>("Domain Initiate", Feats.Instances.DomainInitiate.ID)} feat but must select knowledge, secrecy, or truth as your domain. You cast that domain's domain spell as a focus spell of the same tradition as your cantrip from Eldritch Researcher Dedication, and you {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} by contemplating abstruse mysteries rather than praying to a god. When an ability would manifest a divine symbol—such as the word of truth focus spell—it instead manifests as a strange shape unique to you that seems to defy geometry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6ad5fc03-2612-4471-b2ee-980485f1349d"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87a3ab2e-040a-40dc-9439-f76a20033934"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
