using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryCodebreaker : Template
    {
        public static readonly Guid ID = Guid.Parse("689212a6-174c-4f6d-84ae-6ec2c1fe3623");

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
            yield return new TextBlock { Id = Guid.Parse("3908de5b-fce0-41c5-9e9b-37d6f554f99b"), Type = TextBlockType.Text, Text = $"Your skill with languages and codes is so great that you can decipher information with little more than a quick read through a text. You can {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} using Society while reading at normal speed. If you slow down and spend the full amount of time that's ordinarily required and roll a success, you get a critical success; if you critically succeed while spending the normal amount of time, you gain a nearly word-for-word understanding of the document." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8ae64446-27ec-419e-b2d6-77f1acd8a599"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93af4f84-ac71-4ced-83be-69ebf8fad9c1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
