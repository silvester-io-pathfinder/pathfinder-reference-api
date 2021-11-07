using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("fc17e76c-6ff7-4c52-8105-28e188dc98f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Breadth",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("486343e7-fc7a-4026-8026-816c5f538664"), Type = TextBlockType.Text, Text = "You can cast more divine spells each day. Increase the spell slots you gain from cleric archetype feats by 1 for each spell level other than your two highest cleric spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("629b6382-7846-41b3-9a40-a23b14d4053b"), Feats.Instances.BasicClericSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a8733f7-236f-4e45-a94d-ef94323cb98a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
