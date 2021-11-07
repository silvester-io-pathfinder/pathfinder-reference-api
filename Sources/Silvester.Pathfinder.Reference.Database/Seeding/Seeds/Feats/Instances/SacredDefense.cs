using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SacredDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("8d5ace2f-0a2a-4201-a232-dfe0937ee10b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sacred Defense",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("495d5682-901b-4352-aeeb-afd693bc41f4"), Type = TextBlockType.Text, Text = "You call upon your deity to grant you their protective blessing. Attempt a DC 30 Religion check. If you have legendary proficiency in Religion, you can instead attempt a DC 40 Religion check to increase the temporary Hit Points you gain on a successful check to 15 (25 on a critical success)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("21fa59ab-38b4-4d0f-99f7-013ea1c01013"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("042d1045-a932-4c64-ae23-8a9d825721be"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("86155741-37aa-4ab6-8184-c3d36a847fba"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("199688aa-a43e-487f-a6c3-e9a066afe7ff"),
                CriticalSuccess = "You gain 10 temporary Hit Points. You lose any remaining temporary Hit Points after 1 minute.",
                Success = "You gain 5 temporary Hit Points. You lose any remaining temporary Hit Points after 1 minute.",
                
                CriticalFailure = "Your deity withholds their blessing. You cannot attempt to call to your deity again for 1 day.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7bbe247-6eb3-4edc-b6bb-e25aa7af1d8e"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
