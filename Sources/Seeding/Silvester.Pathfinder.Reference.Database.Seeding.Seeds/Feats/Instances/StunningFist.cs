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
    public class StunningFist : Template
    {
        public static readonly Guid ID = Guid.Parse("745ed92d-f930-4cb4-b581-f47698e181c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stunning Fist",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30de8147-014f-42f6-a22f-929276c7b937"), Type = TextBlockType.Text, Text = $"The focused power of your flurry threatens to overwhelm your opponent. When you target the same creature with two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} from your {ToMarkdownLink<Models.Entities.Feat>("Flurry of Blows", Feats.Instances.FlurryOfBlows.ID)}, you can try to stun the creature. If either {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits and deals damage, the target must succeed at a Fortitude save against your class DC or be stunned 1 (or stunned 3 on a critical failure). This is an {ToMarkdownLink<Models.Entities.Trait>("incapacitation", Traits.Instances.Incapacitation.ID)} effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ec09417d-3577-494a-9b18-e6c3105eb305"), Feats.Instances.FlurryOfBlows.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4b1a27e3-61a2-4184-9dcb-108ef34d83a1"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49c20dd4-c3fc-495c-9c14-183b2ca3b92e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
