using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RevealTrueName : Template
    {
        public static readonly Guid ID = Guid.Parse("e4329a76-b2ad-4f88-a390-93b886a5c0c8");

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
            yield return new TextBlock { Id = Guid.Parse("13fbb39b-77d5-41bd-bdba-9bbcd8dc4308"), Type = TextBlockType.Text, Text = "You attempt to get a creature to do as you wish by threatening them with your knowledge of their true name. You must know and speak the creature’s true name and say what you want the creature to do. Attempt an Intimidation check against the target’s Will DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("15bb3f1a-8c73-4a9e-9862-e7f7e3097867"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.AddOr(Guid.Parse("0a62c2b1-ac1a-4bf9-bc4a-5f866625cb94"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("62db6139-9431-4348-a45d-dab1ba8a0a4c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c0efbc9e-a16e-4eef-a42f-e69f357b44c5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("1e91ff4b-9706-42d2-bb1e-0620a91832d3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("045c0fb1-fc3e-44e0-872d-289e0112ee52"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
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
                Id = Guid.Parse("858514e0-b99f-4ed4-9dcf-c7c772de973f"),
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
                Id = Guid.Parse("a6f5eed4-0724-448b-bf71-26b43167f590"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
