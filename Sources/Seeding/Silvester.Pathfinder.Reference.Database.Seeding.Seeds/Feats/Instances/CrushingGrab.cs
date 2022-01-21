using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrushingGrab : Template
    {
        public static readonly Guid ID = Guid.Parse("710c79e5-2bdb-4919-9474-25b33a8d8cde");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crushing Grab",
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
            yield return new TextBlock { Id = Guid.Parse("e79a6675-51d4-4836-9eb7-d803539b62db"), Type = TextBlockType.Text, Text = $"Like a powerful constrictor, you crush targets in your unyielding grasp. When you successfully {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)} a creature, you can deal bludgeoning damage to that creature equal to your Strength modifier. You can make this attack {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} with no penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2610dfb3-a641-4514-8a25-48cc86c757ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
