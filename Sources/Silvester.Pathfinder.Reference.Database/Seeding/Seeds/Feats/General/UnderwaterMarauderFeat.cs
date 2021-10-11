using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class UnderwaterMarauderFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("dfb5e49e-df3e-443e-bfbf-d41e042306ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underwater Marauder",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55213e09-5320-4baa-9324-35e22eb06496"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve learned to fight underwater. You are not flat-footed while in water, and you don’t take the usual penalties for using a bludgeoning or slashing melee weapon in water." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("52574087-b011-4c5b-9fcb-6e22f11c6091"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("6811cadb-8a91-4a1d-9e0c-9a28c4143c20"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 268
            };
        }
    }
}
