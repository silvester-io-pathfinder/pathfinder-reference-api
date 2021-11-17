using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GracefulLeaper : Template
    {
        public static readonly Guid ID = Guid.Parse("56bd3126-2490-4ac3-8020-186c6b14f13a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Graceful Leaper",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("226fe4a8-f506-400e-a617-ff8b6ffdf4f4"), Type = TextBlockType.Text, Text = "Mass and muscle are meaningless when you leap; only grace and balance matter. You can roll an Acrobatics check instead of an Athletics check when making a (action: High Jump) or (action: Long Jump)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bd77de8b-4426-410e-8380-fe6d808282af"), Feats.Instances.AcrobatDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("589a6125-8dd0-4802-bdf5-a975205ccc5f"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef3762a5-ebc1-4d71-b8ff-c2eb310a1b08"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}