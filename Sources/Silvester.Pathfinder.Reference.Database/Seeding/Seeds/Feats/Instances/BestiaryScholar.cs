using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BestiaryScholar : Template
    {
        public static readonly Guid ID = Guid.Parse("620cfcd8-f9fb-4179-8509-28416c03bfd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bestiary Scholar",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("150459f1-8a94-4e05-b837-0ce7baf17571"), Type = TextBlockType.Text, Text = "You learn how to apply your extensive knowledge of certain creatures using the lore you know. When you gain this feat, choose one of the following skills in which you have attained master proficiency: Arcana, Crafting, Nature, Occultism, or Religion." };
            yield return new TextBlock { Id = Guid.Parse("732fe7f0-5b3f-4db7-861e-7c4aff618859"), Type = TextBlockType.Text, Text = "You can use the chosen skill to (action: Recall Knowledge) to identify any creature normally identifiable by any of the above skills. In addition, when you critically succeed at identifying a creature, you gain a +1 circumstance bonus to your next attack roll or saving throw against that creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("99af5161-057d-4821-a55b-b1e5bc05972d"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("6b32c1b8-9502-429f-9804-59d61e86ee37"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("509f5fa2-89bb-4f0f-90a0-b474e1eb4348"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("62ae950b-c98f-4be1-9768-9729f01f14a1"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("8ea44403-111f-4c51-aee8-e7126d8df3d4"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("2721d265-6940-4369-9d22-eeb60784c4e5"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("29be0e70-2d28-4b54-bbf4-b77923dfd80e"), Feats.Instances.ScollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13ea06e9-2ac8-4b13-9237-d6f985d5707a"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
