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
    public class HybridStudySpell : Template
    {
        public static readonly Guid ID = Guid.Parse("9dc33a0d-e9e3-4049-9efe-934aa97b80de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hybrid Study Spell",
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
            yield return new TextBlock { Id = Guid.Parse("0190624e-95a4-4cbe-b160-37b8fed87654"), Type = TextBlockType.Text, Text = $"Gain the conflux spell from a hybrid study of your choice. If you don't already have one, you gain a focus pool of 1 Focus Point, which you can {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} by studying your spellbook and performing a physical regimen. You don't gain any of the hybrid study's other benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("78594cf2-3e23-41fb-966c-fadfc54229c2"), Feats.Instances.MagusDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fd730e45-bbd2-4e5d-bd9f-62236c7ba383"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ea36064-1b69-489c-b7ef-f1bf792b4f8a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
