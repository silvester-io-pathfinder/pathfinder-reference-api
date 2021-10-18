using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryThiefFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9ee79ba9-47ac-4cf5-906d-9e88190e8d22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Thief",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9dfdb9a4-49d8-41a6-a8ac-2ea5e9e4626c"), Type = Utilities.Text.TextBlockType.Text, Text = "Your ability to Steal defies belief. You can attempt to Steal something that is actively wielded or that would be extremely noticeable or time consuming to remove (like worn shoes or armor). You must do so slowly and carefully, spending at least 1 minute (and significantly longer for items that are normally time consuming to remove, like armor). Throughout this duration you must have some means of staying hidden, such as the cover of darkness or a bustling crowd. You take a –5 penalty to your Thievery check. Even if you succeed, if the item is extremely prominent—like a suit of full plate armor—onlookers will quickly notice it’s gone after you steal it." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("fbc70e79-8d3d-4b12-9fe2-f60f7a3fe5f3"), RequiredSkillId = Skills.Instances.Thievery.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
            yield return new HaveSpecificFeatPrerequisite { Id = Guid.Parse("493d56f0-7760-44fd-948c-20bad99cdf33"), RequiredFeatId = PickpocketFeat.ID };
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
                Id = Guid.Parse("6242919e-dede-4c17-83c8-6e325b77b930"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
