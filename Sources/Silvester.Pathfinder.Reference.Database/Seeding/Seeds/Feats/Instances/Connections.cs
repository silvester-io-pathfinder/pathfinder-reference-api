using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Connections : Template
    {
        public static readonly Guid ID = Guid.Parse("76afeb71-b17f-43a9-9e79-8ed71b2bfa6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Connections",
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
            yield return new TextBlock { Id = Guid.Parse("963a8454-c80e-4f11-b3c5-cde22c40ad6f"), Type = TextBlockType.Text, Text = "You have social connections you can leverage to trade favors or meet important people. When you’re in an area with connections (typically a settlement where you’ve spent downtime building connections, or possibly another area in the same nation), you can attempt a Society check to arrange a meeting with an important political figure or ask for a favor in exchange for a later favor of your contact’s choice. The GM decides the DC based on the difficulty of the favor and the figure’s prominence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6a6c2cac-56f9-4622-a715-bab24f4ae4c9"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("4bfb2fbe-797e-402a-9330-0b81262c1275"), Feats.Instances.CourtleyGraces.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6f322c6-1237-40bd-a1a3-c8a2f3eea6c2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
