using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnticipateAmbush : Template
    {
        public static readonly Guid ID = Guid.Parse("8bbca157-3d1d-42a1-940a-832280e0a01f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anticipate Ambush",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8226a507-96aa-4b5d-9225-f1866f5d87a0"), Type = TextBlockType.Text, Text = "Using your extensive knowledge of ambush tactics, you keep watch for any hidden creatures or dangerous sites, moving at half your travel speed. If you’re Anticipating an Ambush at the start of an encounter, you roll a Perception check for initiative, and all enemies rolling Stealth for initiative take a –2 circumstance penalty to their Stealth checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("20827000-8172-42c0-af8a-3aa5b217a547"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18ffe411-4132-4401-8cd2-077b6caadab0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
