using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixthPillarMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("737e5d13-0634-4634-863a-9b9c085c54ec");

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
            yield return new TextBlock { Id = Guid.Parse("073fdae4-792e-4220-98e6-5903a83fa194"), Type = TextBlockType.Text, Text = $"Your greater discipline aligns your magical and physical potential. If your proficiency rank in unarmed attacks is at least master, your proficiency rank in spell attacks increases to master. Likewise, if your proficiency rank in spell attacks is at least master, your proficiency rank in unarmed attacks improves to master." };
            yield return new TextBlock { Id = Guid.Parse("38c8867d-0e33-4929-b186-68cdab31495a"), Type = TextBlockType.Text, Text = $"__Manually improve your spell attacks and unarmed attacks proficiencies accordingly.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c8cd01b-72e2-4a06-931e-44cc5e0d49f4"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("327130c3-2337-4f13-94d7-5785de726cf8"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
