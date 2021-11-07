using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FoolproofInstructions : Template
    {
        public static readonly Guid ID = Guid.Parse("1715b44d-b29b-4415-a2fd-4978b0d1ed2b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foolproof Instructions",
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
            yield return new TextBlock { Id = Guid.Parse("8954156e-c33c-4e40-8dce-5a3a1f6fb688"), Type = TextBlockType.Text, Text = "You feel confident that you can explain your scrolls so well that even your allies can use them... hopefully. During your daily preparations, you can select a single scroll and instruct a single ally in its use. Until your next daily preparations, the ally can attempt to use the scroll with a single action that has the (trait: manipulate) trait. The ally rolls the skill corresponding to the spellcasting tradition. The GM determines the DC based on the scroll&#39;s level, possibly adjusted for the situation. If the spell has a spell attack bonus or a spell DC, use your level as the proficiency bonus and the highest of your ally&#39;s Intelligence, Wisdom, or Charisma modifiers." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7cf86d47-369b-422f-b061-92d1d767b9ad"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8d6d1e4a-0b11-4ce5-8bcb-976124e772fe"),
                
                Success = "For the rest of the ally&#39;s turn, they can spend actions to (activity: Cast the Spell | Cast a Spell).",
                Failure = "The ally misremembers your instructions and can&#39;t use the scroll this turn.",
                CriticalFailure = "The ally misunderstood your instructions and can&#39;t use the scroll.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dba1f6f-e747-44dd-8888-cb0afa22b410"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
