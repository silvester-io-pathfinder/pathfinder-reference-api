using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoastersChallenge : Template
    {
        public static readonly Guid ID = Guid.Parse("6417460e-8ba3-4890-9a5f-c5cc8aace65b");

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
            yield return new TextBlock { Id = Guid.Parse("048336f0-78a7-45f3-b363-10afd4de5576"), Type = TextBlockType.Text, Text = "You call out a foe, causing them to become flustered and easier to defeat. Select one creature you can see and declare a challenge. For your challenge, attempt a Deception, Diplomacy, or Intimidation check against that creature's Will DC. Your challenge must include a (trait: linguistic), (trait: auditory), or (trait: visual) component and gains the corresponding trait." };
            yield return new TextBlock { Id = Guid.Parse("f5f1edc2-84e6-4d59-bbb7-3e7355c46ed9"), Type = TextBlockType.Text, Text = "If you succeed, you gain a +2 status bonus to damage rolls with your weapon or unarmed (action: Strikes | Strike) against that foe until the end of your next turn; if you have master proficiency in the skill you used, you gain a +4 status bonus instead, and if you're legendary, you gain a +6 status bonus. On a critical success, the status bonus lasts for 3 rounds instead. Whether you succeed or fail, creatures who witnessed your challenge gain a +4 circumstance bonus to their Will DCs against your attempts to challenge for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c430b3fd-8dcd-483b-b758-04c342198417"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("653392b4-3d66-4b61-a7d7-78f487c32579"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("05340b37-f065-423b-9076-7cef93afa40f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Diplomacy.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("9c0a4d00-7624-4d65-8e4f-55848dcb6eed"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("52f47084-0504-4854-931a-a4eb1dc4c64e"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29911376-929d-4c43-a895-dbec1b78edb2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
