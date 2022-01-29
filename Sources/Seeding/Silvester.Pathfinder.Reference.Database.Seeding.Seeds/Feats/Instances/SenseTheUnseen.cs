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
    public class SenseTheUnseen : Template
    {
        public static readonly Guid ID = Guid.Parse("12e4f3b6-8da9-450e-9f27-b7289528a31d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense the Unseen",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a check to Seek.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86e0d0d4-3cbc-4ada-9616-b04be73b3430"), Type = TextBlockType.Text, Text = $"When you look for foes, you can catch even the slightest cues, such as their minute movements or the shifting of air currents on your skin. Even though you failed at the triggering check, you automatically sense any undetected creatures in the area where you're {ToMarkdownLink<Models.Entities.Action>("Seeking", Actions.Instances.Seek.ID)}, making them merely hidden to you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a5c1ebfd-6c19-4965-9422-7ebf30f096cb"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("40a43425-e1f6-4411-88d6-3a8be3d37072"), Traits.Instances.Investigator.ID);
            builder.Add(Guid.Parse("a1ed6980-ac85-4308-87c0-065b80717686"), Traits.Instances.Ranger.ID);
            builder.Add(Guid.Parse("ace99b0c-7b15-4b66-aeb8-2acc471223c9"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37a70535-f0d4-42f2-979a-7f4c2bd74ddf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
