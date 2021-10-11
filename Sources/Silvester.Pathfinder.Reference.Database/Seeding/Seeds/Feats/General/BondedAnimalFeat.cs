using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class BondedAnimalFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("0422a543-ec8f-4c04-9e15-5b4fd5c1f065");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bonded Animal",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b8ded86-03cd-412f-a306-67aead75c577"), Type = Utilities.Text.TextBlockType.Text, Text = "You forge strong connections with animals. You can spend 7 days of downtime regularly interacting with a normal animal (not a companion or other special animal) that is friendly or helpful to you. After this duration, attempt a DC 20 Nature check. If successful, you bond with the animal. The animal is permanently helpful to you, unless you do something egregious to break your bond. A helpful animal is easier to direct, as described under Command an Animal on page 249. Bonding with a new animal ends any previous bond you had. You can’t have both a bonded animal and an animal companion (though you can have both a bonded animal and a familiar)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("add7f52e-652d-4950-83bf-fc78dcec4a4b"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25582f43-470e-4a24-9a7a-668784df51e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 259
            };
        }
    }
}
