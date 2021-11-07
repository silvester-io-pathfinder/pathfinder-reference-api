using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoastersChallenge : Template
    {
        public static readonly Guid ID = Guid.Parse("f41fdb49-5bfc-400a-a5df-c2c68f3138c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boaster's Challenge",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f49892cf-1a67-468a-bd48-698b757a19de"), Type = TextBlockType.Text, Text = "You call out a foe, causing them to become flustered and easier to defeat. Select one creature you can see and declare a challenge. For your challenge, attempt a Deception, Diplomacy, or Intimidation check against that creature’s Will DC. Your challenge must include a (trait: linguistic), (trait: auditory), or (trait: visual) component and gains the corresponding trait." };
            yield return new TextBlock { Id = Guid.Parse("ae85f940-8b7e-4723-b1ed-46dab3ec829a"), Type = TextBlockType.Text, Text = "If you succeed, you gain a +2 status bonus to damage rolls with your weapon or unarmed (action: Strikes | Strike) against that foe until the end of your next turn; if you have master proficiency in the skill you used, you gain a +4 status bonus instead, and if you’re legendary, you gain a +6 status bonus. On a critical success, the status bonus lasts for 3 rounds instead. Whether you succeed or fail, creatures who witnessed your challenge gain a +4 circumstance bonus to their Will DCs against your attempts to challenge for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b9078c44-ad95-44b1-8c90-4ca1096f8627"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("6cd31656-6213-417e-98b9-1c8ae08cb86c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("6fbd84ea-492c-42a0-9756-64eb6fa2325d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Diplomacy.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("fbc8c973-4410-415e-b9da-cf5bf2e79163"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("5d08fdb7-4aac-4182-aff1-3abd8fab3258"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("622487bd-8653-4dda-a992-e8168ec4fc31"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
