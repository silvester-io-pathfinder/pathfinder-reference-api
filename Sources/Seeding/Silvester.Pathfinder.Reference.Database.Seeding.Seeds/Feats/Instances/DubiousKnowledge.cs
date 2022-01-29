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
    public class DubiousKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("f9b07c4a-835b-4548-8e2d-ee702509f587");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dubious Knowledge",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d169ac05-8bcb-48b5-992b-0b7a95b8f538"), Type = TextBlockType.Text, Text = $"You're a treasure trove of information, but not all of it comes from reputable sources. When you fail (but not critically fail) a {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} check using any skill, you learn a bit of true knowledge and a bit of erroneous knowledge, but you don't have any way to differentiate which is which." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("3262f9aa-c4b2-42b4-adc7-c3b9a245bcba"), Proficiencies.Instances.Trained.ID, requiresAssurance: false);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f46ae554-cda9-4fe4-acff-92e325762b1f"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("df622685-529c-46e0-a56e-52df3e40d478"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e9ee06e-2294-404f-b202-a91444721dce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
