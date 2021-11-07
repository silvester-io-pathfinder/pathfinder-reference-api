using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RevealTrueName : Template
    {
        public static readonly Guid ID = Guid.Parse("9afbefef-6ff7-44a9-b5be-9bc602c63474");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reveal True Name",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b64f15e-3bd2-4dc5-bc42-cb90d7568c89"), Type = TextBlockType.Text, Text = "You attempt to get a creature to do as you wish by threatening them with your knowledge of their true name. You must know and speak the creature’s true name and say what you want the creature to do. Attempt an Intimidation check against the target’s Will DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("68fe278c-aa06-498f-b7aa-0a9231305cb5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.AddOr(Guid.Parse("8bd9de29-f6da-474c-bb5e-89366884909c"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("67814d52-b674-4f0f-9ae9-dcdd5f45cf9c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("11bb5b26-3f01-4d85-9cd5-7324a84b9392"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("ed988825-3814-48fc-81ed-43c991cd0ac8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("1428ab93-8164-4e11-9850-b3b95c6332b4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b252c891-1e50-4fc4-bd50-2d1c7d8aadfe"),
                CriticalSuccess = "The target does as you say out of a sense of self-preservation, and will not harm itself in any way. It becomes unfriendly (if it wasn’t already unfriendly or hostile) but continues to comply for up to 1 day. The target is too scared of you to retaliate or flee, certain you would find them wherever they might go.",
                Success = "As critical success, but once the target becomes unfriendly, they avoid you and might act against you in an indirect manner, such as alerting your enemies to your location.",
                Failure = "The target refuses to comply and typically flees your presence to avoid your further use of their true name. If they were not already unfriendly or hostile, they become unfriendly. They avoid you in the future and are likely to take indirect action against you.",
                CriticalFailure = "The target refuses to comply and becomes hostile, if it wasn’t already. If they perceive you as weak, they might attack you; otherwise, they likely flee to avoid your further use of their true name.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("849465cb-d92f-4420-960d-a41bfaa58e72"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
