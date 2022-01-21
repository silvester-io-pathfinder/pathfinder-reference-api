using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnticipateAmbush : Template
    {
        public static readonly Guid ID = Guid.Parse("ecfb8e2f-5849-468f-8d59-21cd71748997");

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
            yield return new TextBlock { Id = Guid.Parse("c58d71e8-2ab4-40e4-9198-116646234222"), Type = TextBlockType.Text, Text = $"Using your extensive knowledge of ambush tactics, you keep watch for any hidden creatures or dangerous sites, moving at half your travel speed. If you're Anticipating an Ambush at the start of an encounter, you roll a Perception check for initiative, and all enemies rolling Stealth for initiative take a –2 circumstance penalty to their Stealth checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("fd381a17-b538-4d06-961e-783d8be086c2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("113a9869-b3b0-4986-bc85-3631d16f2e98"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
