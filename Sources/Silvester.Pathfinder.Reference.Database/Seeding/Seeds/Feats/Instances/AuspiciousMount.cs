using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuspiciousMount : Template
    {
        public static readonly Guid ID = Guid.Parse("a7543804-7fd6-4453-8787-f69ad27d3eb3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Auspicious Mount",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f25a83e-81ea-4c60-a184-41917777f875"), Type = TextBlockType.Text, Text = "Guided by your ongoing care, your steed has developed incredible intelligence and skill. The mount you gained through the divine ally class feature is now a specialized animal companion (page 217). You can select one of the usual specializations or the auspice specialization." };
            yield return new TextBlock { Id = Guid.Parse("0719f0fc-f86e-4c06-86b1-5a575a412227"), Type = TextBlockType.Text, Text = "Auspice mounts gain the following benefits: Your companion is marked by your deity’s religious symbol as a sacred creature of your deity. Its proficiency rank in Religion increases to expert, it can speak the language associated with your deity’s servitors (Celestial for champions who follow the tenets of good), and its Intelligence modifier increases by 2 and its Wisdom modifier by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("a5f70169-b439-4ac8-a774-4d4f9a6c007b"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificFeat(Guid.Parse("d62c6e40-9940-4298-8570-f77795654003"), Feats.Instances.ImposingDestrier.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a8a3c5f-d693-4c74-812c-8c36113b70c6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
