using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossiblePolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("3dd3a7d6-7946-42b6-94e4-c1cfb23b173e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Polymath",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47047978-c256-4a87-a081-4eb7462f89fd"), Type = TextBlockType.Text, Text = "Your esoteric formulas are so unusual that they allow you to dabble in magic from diverse traditions that other bards don’t understand. As long as you’re trained in Arcana, you can add arcane spells to your book from (feat: Esoteric Polymath); as long as you’re trained in Nature, you can add primal spells to your book; and as long as you are trained in Religion, you can add divine spells to your book." };
            yield return new TextBlock { Id = Guid.Parse("21d9b799-b9a7-44a3-83ba-b4cc529a8c3d"), Type = TextBlockType.Text, Text = "Like your other spells in your book, you can add one of these spells from another tradition to your repertoire as an occult spell each day using (feat: Esoteric Polymath), but you can’t retain any spells from another tradition when you prepare again, even if you have (feat: Eclectic Polymath)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("8b3bc17f-f159-4e0b-81c7-d473ae68fd63"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("660b888d-4c8b-42fe-b9c3-1caf3982d010"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c9b842b0-0b6d-4a52-bddd-f500e7a39333"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("9715d60c-8c4a-4c16-9b90-c26bdd6d7222"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("9ae59a60-6dae-4306-ba62-76004f8f5e07"), Feats.Instances.EsotericPolymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1ac63ad-b516-475b-8cc6-20e45adf7571"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
