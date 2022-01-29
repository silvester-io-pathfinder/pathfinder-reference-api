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
    public class FeatherStep : Template
    {
        public static readonly Guid ID = Guid.Parse("d04462e5-7710-41c4-901f-9f0f892ace24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feather Step",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87889dcd-de79-4cdc-ae3c-77ec165ad5bf"), Type = TextBlockType.Text, Text = $"You step carefully and quickly. You can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} into difficult terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("a8a719ff-863a-41a8-a4b9-a41adeccdef2"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2719dece-7d04-41fe-ae2e-b79fe3192ec9"), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c11607fd-aa74-4d2d-97a7-ca0e33ef93af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
