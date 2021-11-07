using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixthPillarMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("721dc98c-1143-4c81-a38b-049d9261b833");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sixth Pillar Mastery",
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
            yield return new TextBlock { Id = Guid.Parse("0091942f-a20c-4d82-8a96-16e6ad1c71fa"), Type = TextBlockType.Text, Text = "Your greater discipline aligns your magical and physical potential. If your proficiency rank in unarmed attacks is at least master, your proficiency rank in spell attacks increases to master. Likewise, if your proficiency rank in spell attacks is at least master, your proficiency rank in unarmed attacks improves to master." };
            yield return new TextBlock { Id = Guid.Parse("258db470-c2ec-46e6-a7e3-7bdc8b5d1fe6"), Type = TextBlockType.Text, Text = "__Manually improve your spell attacks and unarmed attacks proficiencies accordingly.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5a208861-003a-42ed-96d8-f380beba4c48"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("734a070e-f2a9-423c-bd62-e502a78bbe60"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
