using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class CourtlyGracesFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("5c26de36-847d-4a16-8871-0a2016fdfacc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courtly Graces",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38b5844d-0409-48fd-ab87-07bbe0e02f68"), Type = Utilities.Text.TextBlockType.Text, Text = "You were raised among the nobility or have learned proper etiquette and bearing, allowing you to present yourself as a noble and play games of influence and politics. You can use Society to Make an Impression on a noble, as well as with Impersonate to pretend to be a noble if you aren’t one. If you want to impersonate a specific noble, you still need to use Deception to Impersonate normally, and to Lie when necessary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("948b49bd-4759-47e9-924c-f0655daf58bd"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
