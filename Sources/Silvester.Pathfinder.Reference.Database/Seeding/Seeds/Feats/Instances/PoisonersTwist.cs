using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonersTwist : Template
    {
        public static readonly Guid ID = Guid.Parse("697cab4a-8b77-4467-ba98-423f88bb2486");

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
            yield return new TextBlock { Id = Guid.Parse("e70a68f2-a7cf-4af9-be0d-fcfcacae82e9"), Type = TextBlockType.Text, Text = "Poisons attack specific parts of the body – one venom might target the lungs, another the circulatory system, while another deteriorates the nerves. You know how to take advantage of such weaknesses. You deal 1d6 damage of the required (action: Strike)’s damage type and 1d6 poison damage to the target. If you’re at least 18th level, you deal 2d6 damage of each type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("26ab7214-8e3a-4100-9a54-2333edd2ffd0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a024bf71-9bcd-445b-9222-62656c717b2f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
