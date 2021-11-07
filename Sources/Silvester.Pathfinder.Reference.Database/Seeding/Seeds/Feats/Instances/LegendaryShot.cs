using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryShot : Template
    {
        public static readonly Guid ID = Guid.Parse("b5550c42-06d1-4359-b43e-d6fb740e516d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Shot",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a0b6354-5f2c-42d7-807d-440bcc7987cd"), Type = TextBlockType.Text, Text = "You focus on your hunted prey, perceiving angles, air resistance, and every variable that would affect your ranged attack. If you have master proficiency with your ranged weapon, you can ignore the penalty for attacking up to five range increments away when attacking your hunted prey." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("62181951-2650-423a-a8a9-e4fc606f9007"), Feats.Instances.MasterfulHunter.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("eee9a9ff-9ba8-4c2b-8047-b6f6b17dde3a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
            builder.HaveSpecificFeat(Guid.Parse("b623ec6c-9ec4-40bc-999c-144ca7395bb4"), Feats.Instances.FarShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a263bb9f-0e66-4242-8a90-956fa6e62592"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
