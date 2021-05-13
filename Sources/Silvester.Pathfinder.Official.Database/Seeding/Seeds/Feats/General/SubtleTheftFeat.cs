using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SubtleTheftFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("2818e8e6-4d55-4f83-ad45-6decff2673c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Theft",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("78f751ba-70e0-475e-89fc-d2f5f5006e43"), Type = Utilities.Text.TextBlockType.Text, Text = "When you successfully Steal something, observers (creatures other than the creature you stole from) take a –2 circumstance penalty to their Perception DCs to detect your theft. Additionally, if you first Create a Diversion using Deception, taking a single Palm an Object or Steal action doesn’t end your undetected condition." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("58a9af14-93bc-4de1-b290-645b961952a1"), RequiredSkillId = Skills.Instances.Thievery.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID};
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
