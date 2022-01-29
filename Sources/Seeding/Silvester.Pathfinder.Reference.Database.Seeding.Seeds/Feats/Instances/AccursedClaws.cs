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
    public class AccursedClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("7b566b19-6b4c-4baa-9548-dc027b41100c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accursed Claws",
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
            yield return new TextBlock { Id = Guid.Parse("c16720aa-4599-4171-bb13-d67c4fc9638a"), Type = TextBlockType.Text, Text = $"Your claws carry your mother's hag magic. When you critically hit with a claw {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, the target takes an additional 1d4 persistent mental damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("f37f0d78-df7b-4c90-b1f3-17e633f02016"), UnarmedWeapons.Instances.Claws.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5f8992c7-10e4-44c7-8f31-edeea0bb4e44"), Traits.Instances.Changeling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("883d3c66-df34-42bf-a166-d023b429d2a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
