using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BattlePrayer : Template
    {
        public static readonly Guid ID = Guid.Parse("66118347-21a9-432a-950d-2638d80f9b64");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Prayer",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e6003bc-2993-4068-81fc-9215b9834e9e"), Type = TextBlockType.Text, Text = "Calling out to your deity, you recite scripture to harm a foe. When you select this feat, choose (trait: chaos | chaotic), (trait: evil), (trait: good), or (trait: law | lawful). Your choice must match one of your deity’s alignment components. This action has the trait corresponding to the chosen alignment." };
            yield return new TextBlock { Id = Guid.Parse("eece852f-602f-4eb8-a470-3c64341690c2"), Type = TextBlockType.Text, Text = "Attempt a Religion check against the Will DC of a foe within 30 feet. The foe is then temporarily immune to Battle Prayers from your deity for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("224b7042-a796-4cb3-bc0c-8c7f1c01a1c3"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("c92b3ef1-653e-4904-bc14-43e7717fc00f"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.FollowAnyReligion(Guid.Parse("905110a7-7b29-43c9-af27-a266c3481d3a"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("083a4867-df13-4b7e-a1dd-f210e1bab8bc"),
                CriticalSuccess = "You deal 2d6 damage of the chosen alignment type, or 6d6 damage if you have legendary proficiency in Religion.",
                Success = "You deal 1d6 damage of the chosen alignment type, or 3d6 damage if you have legendary proficiency in Religion.",
                Failure = "There is no effect.",
                CriticalFailure = "The backlash of your foe’s will against your prayer prevents you from using Battle Prayer again for 10 minutes.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("571a0c06-8fc0-49b6-8762-c8521c35dffb"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
