using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LesserAugmentation : Template
    {
        public static readonly Guid ID = Guid.Parse("0fedb92f-31f2-4fbf-b8eb-ede3afddc68d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesser Augmentation",
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
            yield return new TextBlock { Id = Guid.Parse("519fe8c6-ecc0-4640-a55f-f265929249c5"), Type = TextBlockType.Text, Text = "You’ve focused on enhancing yourself and have received an improvement to one of your existing abilities. You gain the enhancement benefits of one of your 1st- or 5th-level automaton ancestry feats." };
            yield return new TextBlock { Id = Guid.Parse("86f780b3-59fb-4b57-8d8e-3b61561c4b92"), Type = TextBlockType.Text, Text = "You are also capable of reconfiguring your augmentations to meet your needs. You can spend one week of downtime to change the enhancement you gain with this feat." };
            yield return new TextBlock { Id = Guid.Parse("fb3b9533-9138-4caa-a5d8-9a7744389a3d"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("cbfdc40b-c932-497a-baf8-b7ce2b7a013b"), Type = TextBlockType.Text, Text = "~ Enhancement: You gain the enhancement benefits of another 1st- or 5th-level automaton ancestry feat. Also, your reconfigurations take less time. You only need to spend 1 day of downtime to change any of your enhancements. If you have multiple enhancements, changing each one requires a separate day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63e2be50-19a7-4e74-bda7-90c024619222"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
