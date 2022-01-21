using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WonderWorker : Template
    {
        public static readonly Guid ID = Guid.Parse("88bdb364-37df-4536-bb2f-604da1f2a655");

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
            yield return new TextBlock { Id = Guid.Parse("377eab79-43c1-4f50-8df0-5ca14c53fe2b"), Type = TextBlockType.Text, Text = "You've transcended to the culmination of the thaumaturge's path, gaining the ability to work wonders. Once per day, you can call upon your power to cast a spell of 8th level or lower that takes 1, 2, or 3 actions to cast. The spell must be common or one to which you have access. You can choose a spell of any tradition for which you're legendary in the associated skill (Arcana for arcane, Nature for primal, Occultism for occult, or Religion for divine). Use your thaumaturge class DC in place of any necessary spell DC and your thaumaturge class DC – 10 in place of any necessary counteract modifier or spell attack modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("ffaec6de-b38f-40f5-a9fc-d7783e518fd0"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("66080532-6e06-4464-924b-3821d64ee7d4"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("8778ff78-b365-44f3-84ff-8a2815143938"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("bb2e6e59-b711-4f3d-bc76-4eaed531f40b"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("e0d7c4aa-1d87-48d7-8c86-1f396fb8bd28"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
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
                Id = Guid.Parse("0a7c91a5-945c-470e-8cbf-2491625d1041"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
