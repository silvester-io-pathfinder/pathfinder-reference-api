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
    public class UnbelievableLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("2afd5946-5537-49fa-876e-997ea76c4379");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbelievable Luck",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d60ba18-c2b3-430f-95bd-42d06cdfdb89"), Type = TextBlockType.Text, Text = $"While no one, not even you, might appear to understand why, you demonstrate a greater ability to hit your targets regardless of the obstacles in your way. You can use the {ToMarkdownLink<Models.Entities.Feat>("Accidental Shot", Feats.Instances.AccidentalShot.ID)} activity granted to you by the Unexpected Sharpshooter Dedication once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e3afa723-fb11-4cdf-908d-fd90ea9d54c1"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d5a7b3f5-8f4f-447e-949b-9ea6624083f1"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2a09b73-0993-4b23-8c78-81ced3490dc2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
