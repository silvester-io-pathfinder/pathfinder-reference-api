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
    public class OffensiveSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("f0d7f600-130b-41b7-adf4-e8ccb49b3174");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Offensive Subroutine",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5aaa0f9-7a66-42bf-8644-bce194971c48"), Type = TextBlockType.Text, Text = $"Nanites augment your attacks. You can choose to activate {ToMarkdownLink<Models.Entities.Feat>("Nanite Surge", Feats.Instances.NaniteSurge.ID)} when you attempt an attack roll, instead of when you attempt a skill check. If you do, you gain a +1 status bonus to the triggering attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("753305e8-09f2-4876-93b2-98ce700d8463"), Feats.Instances.NaniteSurge.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Android.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e614317a-602a-4e89-8cf7-1d442ea247aa"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
