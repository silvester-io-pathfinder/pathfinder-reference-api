using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WonderWorker : Template
    {
        public static readonly Guid ID = Guid.Parse("98048e4b-b706-49c3-8969-cfa8a2e6065d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wonder Worker",
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
            yield return new TextBlock { Id = Guid.Parse("4a3897d7-9b2d-4e27-81fb-6d9a5da05f3a"), Type = TextBlockType.Text, Text = "You’ve transcended to the culmination of the thaumaturge’s path, gaining the ability to work wonders. Once per day, you can call upon your power to cast a spell of 8th level or lower that takes 1, 2, or 3 actions to cast. The spell must be common or one to which you have access. You can choose a spell of any tradition for which you’re legendary in the associated skill (Arcana for arcane, Nature for primal, Occultism for occult, or Religion for divine). Use your thaumaturge class DC in place of any necessary spell DC and your thaumaturge class DC – 10 in place of any necessary counteract modifier or spell attack modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("dd0161e2-7c9c-4819-b3b1-213bda1d5b54"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("1d409f0a-191e-46e7-8504-9046a954437a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("9f20e42d-2ecf-4fbe-94bd-fd74dee59a7c"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("5bf34e9b-2c7c-4e17-b516-6e6896be3a18"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("cdffc0d3-907b-4b34-a6f4-452a90ce2c56"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cd8c73c-4621-4f28-b66f-edcca7176e88"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
