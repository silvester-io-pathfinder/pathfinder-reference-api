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
    public class EldritchResearcherDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("a9bd0238-20a7-4ca3-b172-3cc8a42c16d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Researcher Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the Eldritch Researcher archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cf0bf92-5cd3-4fb7-9692-3a1958760582"), Type = TextBlockType.Text, Text = $"You gain the ability to cast a single arcane or occult cantrip of your choice (which is heightened to a spell level equal to half your level rounded up). If you weren't already, you become trained in that tradition's spell DCs and spell attack rolls with Intelligence as your spellcasting ability." };
            yield return new TextBlock { Id = Guid.Parse("9ea108cf-246d-4468-87bd-caca7bebeee3"), Type = TextBlockType.Text, Text = $"Regardless of whether you choose an arcane or occult cantrip, you also become an expert in your choice of either Arcana or Occultism. You also gain a +1 circumstance bonus to checks you attempt with the chosen skill when {ToMarkdownLink<Models.Entities.Activity>("Investigating", Activities.Instances.Investigate.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Identifying Magic", SkillActions.Instances.IdentifyMagic.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d8f72c57-0226-4500-aae2-1e0f866c7f72"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("80554aaf-219b-4dde-a6f1-5770991cf50f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a201e095-a963-4d39-98e9-3cb053c50b16"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
