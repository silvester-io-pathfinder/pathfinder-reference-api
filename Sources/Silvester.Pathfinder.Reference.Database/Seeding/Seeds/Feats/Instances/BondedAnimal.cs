using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BondedAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("38cca17a-ca6d-4513-8632-c2d6796a1d4c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bonded Animal",
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
            yield return new TextBlock { Id = Guid.Parse("fc9f5bc4-703a-4472-a82c-7dc83111bd81"), Type = TextBlockType.Text, Text = "You forge strong connections with animals. You can spend 7 days of downtime regularly interacting with a normal animal (not a companion or other special animal) that is friendly or helpful to you. After this duration, attempt a DC 20 Nature check. If successful, you bond with the animal. The animal is permanently helpful to you, unless you do something egregious to break your bond. A helpful animal is easier to direct, as described under (Action: Command an Animal)." };
            yield return new TextBlock { Id = Guid.Parse("0cf13c95-1bec-4d98-86ad-4d4e019a4685"), Type = TextBlockType.Text, Text = "Bonding with a new animal ends any previous bond you had. You can’t have both a bonded animal and an animal companion (though you can have both a bonded animal and a familiar)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("17f90f32-4ec4-464e-ae13-f79dd378feae"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f63a624-72cb-4ae1-a60c-62c314f44be7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
