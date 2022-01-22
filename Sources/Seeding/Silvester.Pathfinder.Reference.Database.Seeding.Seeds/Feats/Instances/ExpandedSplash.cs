using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpandedSplash : Template
    {
        public static readonly Guid ID = Guid.Parse("ede0e8d2-2c97-4b49-b0d6-5573dd13bf3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expanded Splash",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b475a240-5a08-4ac9-b458-5a275c05567e"), Type = TextBlockType.Text, Text = $"The particularly volatile compounds that you brew into your bombs result in them creating especially large and powerful explosions. When you throw an alchemical bomb and that bomb has the {ToMarkdownLink<Models.Entities.Trait>("splash", Traits.Instances.Splash.ID)} trait, you can add your Intelligence modifier to the bomb's usual splash damage, and it deals splash damage to every creature within 10 feet of the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("15e772e2-0ff9-4739-89be-5bfb202bb413"), Feats.Instances.CalculatedSplash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61a09c94-adb5-4a71-9c2e-65e10c2fb7b9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
