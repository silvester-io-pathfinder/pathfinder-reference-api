using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonersTwist : Template
    {
        public static readonly Guid ID = Guid.Parse("0992c392-f36f-4257-8092-89ad9e7ea4cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poisoner's Twist",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee716449-e617-4d24-b89e-2d2f225563e5"), Type = TextBlockType.Text, Text = "Poisons attack specific parts of the body – one venom might target the lungs, another the circulatory system, while another deteriorates the nerves. You know how to take advantage of such weaknesses. You deal 1d6 damage of the required (action: Strike)’s damage type and 1d6 poison damage to the target. If you’re at least 18th level, you deal 2d6 damage of each type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("909f7d83-9f85-4a55-81a4-1289b66cdce7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60f61bf4-bb0f-4177-b5c1-dd6ad3260fbe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
