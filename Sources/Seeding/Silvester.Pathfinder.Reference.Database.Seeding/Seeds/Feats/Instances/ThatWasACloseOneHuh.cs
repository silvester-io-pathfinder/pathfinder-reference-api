using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThatWasACloseOneHuh : Template
    {
        public static readonly Guid ID = Guid.Parse("e7e10e42-b61e-478a-8855-654e841f0194");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "That Was a Close One, Huh?",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8834a3b4-342d-4b17-a727-8c67d17aab4f"), Type = TextBlockType.Text, Text = "You laugh innocently about the inexplicable luck of your last shot hitting its mark or how close the attack that just missed you came to taking your head off, causing your foes to second guess whether it's a good idea to oppose you in battle. Attempt to (action: Demoralize) either the foe you hit with (feat: Accidental Shot) or the foe that missed you due to (feat: Lucky Escape). You use Deception instead of Intimidation to attempt the check to (action: Demoralize)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6b7d663a-0edd-4382-80f8-de13908fc66a"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("bc3fd1e8-f040-414c-af8c-028e328cf273"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c1034b3-e164-43b9-b51e-4d79a352deb8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
