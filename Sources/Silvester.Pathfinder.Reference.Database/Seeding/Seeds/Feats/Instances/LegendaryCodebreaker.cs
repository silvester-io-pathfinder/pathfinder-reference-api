using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryCodebreaker : Template
    {
        public static readonly Guid ID = Guid.Parse("8fbe8315-61d2-498d-87ac-e10ce08567fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Codebreaker",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39a59c0f-929e-42da-bbf2-b1c09be4af3c"), Type = TextBlockType.Text, Text = "Your skill with languages and codes is so great that you can decipher information with little more than a quick read through a text. You can (Action: Decipher Writing) using Society while reading at normal speed. If you slow down and spend the full amount of time that’s ordinarily required and roll a success, you get a critical success; if you critically succeed while spending the normal amount of time, you gain a nearly word-for-word understanding of the document." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("96b00383-2240-4b1d-8cef-f755dc7d8e29"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("766400f8-82f7-4935-968b-059a33dab02b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
