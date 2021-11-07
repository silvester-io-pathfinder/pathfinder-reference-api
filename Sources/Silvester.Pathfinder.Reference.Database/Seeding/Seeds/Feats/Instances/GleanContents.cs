using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GleanContents : Template
    {
        public static readonly Guid ID = Guid.Parse("76e82ee2-d4a2-4105-8ecb-a990d5ee0a6a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glean Contents",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49b3140a-3e4d-4802-8342-c00bde40431d"), Type = TextBlockType.Text, Text = "You are adept at quickly scanning loose papers and carefully discerning the contents of sealed letters without damaging the seal. You can attempt Society checks to (action: Decipher Writing | Decipher Writing - Society) on a message that is only partially glimpsed, upside down or reversed from your perspective, or even sealed. However, on a critical failure, the recipient is made aware of your efforts (for instance, you damage the seal or disturb the papers in some way). When using this feat to decipher sealed letters, your attempt to (action: Decipher Writing) gains the (trait: manipulate) trait. This feat doesn’t prevent witnesses from noticing your efforts, particularly with sealed letters which you must manipulate directly in order to read; you might need to attempt Deception or Stealth checks to avoid being noticed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bda0169a-1b64-4fb1-8f82-4156446838a1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("447c1a62-8d50-4cbb-9ddd-8be7b9421cc9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
