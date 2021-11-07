using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThatWasACloseOneHuh : Template
    {
        public static readonly Guid ID = Guid.Parse("57bcd8a3-bbdd-4c3c-b84a-168b7aab42d8");

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
            yield return new TextBlock { Id = Guid.Parse("0cd7a292-0e98-40be-801a-bf190157ff61"), Type = TextBlockType.Text, Text = "You laugh innocently about the inexplicable luck of your last shot hitting its mark or how close the attack that just missed you came to taking your head off, causing your foes to second guess whether it’s a good idea to oppose you in battle. Attempt to (action: Demoralize) either the foe you hit with (feat: Accidental Shot) or the foe that missed you due to (feat: Lucky Escape). You use Deception instead of Intimidation to attempt the check to (action: Demoralize)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8325f78f-d9e6-4936-b7bf-6eaf5fac72d5"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("de5988f5-fa88-4562-96e5-3a82da6062e7"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76b0f387-0eff-4d48-8210-660a891cbf26"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
