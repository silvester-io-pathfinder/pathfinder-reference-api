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
    public class RobustRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("5d914c1e-ca53-4683-a65e-acf927346071");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Robust Recovery",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7aedc71d-fce5-490f-85d5-80035c5c6023"), Type = TextBlockType.Text, Text = $"You learned folk medicine to help recover from diseases and poison, and using it diligently has made you especially resilient. When you {ToMarkdownLink<Models.Entities.SkillAction>("Treat a Disease", SkillActions.Instances.TreatDisease.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Treat a Poison", SkillActions.Instances.TreatPoison.ID)}, or someone else uses one of these actions on you, increase the circumstance bonus granted on a success to +4, and if the result of the patient's saving throw is a success, the patient gets a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5247168a-bd11-4e11-b9d6-aae0293ac090"), Proficiencies.Instances.Expert.ID, Skills.Instances.Medicine.ID);
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
                Id = Guid.Parse("0943c011-717f-410c-8d89-840262aabcf0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
