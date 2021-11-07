using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FabricatedConnections : Template
    {
        public static readonly Guid ID = Guid.Parse("27734e75-f277-4241-ba5b-f08d2cad90bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fabricated Connections",
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
            yield return new TextBlock { Id = Guid.Parse("a2f19719-bfd2-491b-9b33-45142d0357a8"), Type = TextBlockType.Text, Text = "You can lie about having taken an action so convincingly that you acquire all the tangible benefits of having successfully completed it. You can roll Deception in place of a different skill when attempting to (action: Earn Income), (action: Make an Impression), (action: Request), or (action: Subsist). You can use Fabricated Connections to (action: Make an Impression) or (action: Request) once per day, and you can also use it once per week to (action: Earn Income) or (action: Subsist)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f6756b2b-cb1c-49cf-8591-4816d3ec17be"), Feats.Instances.DandyDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("652d7e8e-102c-4cee-8ebc-ba3954c1a031"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e794b9de-db62-4521-a823-3e5dd84b0e2e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
