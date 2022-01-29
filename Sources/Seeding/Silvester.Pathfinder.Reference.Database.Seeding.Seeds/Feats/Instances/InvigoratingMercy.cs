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
    public class InvigoratingMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("e82e6dde-50dc-4aa8-a2d0-3e8ae2258b54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invigorating Mercy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c4f660f-53eb-41dc-b935-970874b7b4fe"), Type = TextBlockType.Text, Text = $"Your divine touch rejuvenates the weak and tired. When you use {ToMarkdownLink<Models.Entities.Feat>("Mercy", Feats.Instances.Mercy.ID)}, you can instead attempt a counteract check to remove the clumsy or enfeebled conditions, using the source of that condition to determine the counteract level and DC. If the condition was caused by an ongoing effect and you don't remove that effect, the condition returns at the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("42e3c5c4-b462-4574-bd50-dc33a2cecfe6"), Feats.Instances.Mercy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a77d04d1-49bf-49b4-8388-2c03e4f7f5af"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
