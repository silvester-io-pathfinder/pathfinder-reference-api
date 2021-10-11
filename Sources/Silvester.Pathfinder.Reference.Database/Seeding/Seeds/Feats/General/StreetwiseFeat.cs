using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class StreetwiseFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("7de0d323-fc78-4154-a4d0-91e8af5ef631");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Streetwise",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b49e4a7d-a147-40c2-a552-b71770e29367"), Type = Utilities.Text.TextBlockType.Text, Text = "You know about life on the streets and feel the pulse of your local settlement. You can use your Society modifier instead of your Diplomacy modifier to Gather Information. In any settlement you frequent regularly, you can use the Recall Knowledge action with Society to know the same sorts of information that you could discover with Diplomacy to Gather Information. The DC is usually significantly higher, but you know the information without spending time gathering it. If you fail to recall the information, you can still subsequently attempt to Gather Information normally." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("7417ee71-aa5a-4d7e-89f4-a7c2f1fbb3f0"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID};
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9588132d-ba05-4afe-8923-9737a11c34f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 267
            };
        }
    }
}
