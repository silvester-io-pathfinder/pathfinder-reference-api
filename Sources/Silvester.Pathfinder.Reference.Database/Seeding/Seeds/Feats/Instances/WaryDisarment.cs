using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaryDisarment : Template
    {
        public static readonly Guid ID = Guid.Parse("3d5ed67d-03a1-408e-a564-35e35159219c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wary Disarment",
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
            yield return new TextBlock { Id = Guid.Parse("44d641fb-b6b5-482d-bd7b-33490e46d0ed"), Type = TextBlockType.Text, Text = "If you trigger a device or set off a trap while disarming it, you gain a +2 circumstance bonus to your AC or saving throw against the device or trap. This applies only to attacks or effects triggered by your failed attempt, not to any later ones, such as additional attacks from a complex trap." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3608443c-2503-4e54-991f-87d5d5cb72d8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce99811b-34b3-4c2b-ae71-fc228fc93cc3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
