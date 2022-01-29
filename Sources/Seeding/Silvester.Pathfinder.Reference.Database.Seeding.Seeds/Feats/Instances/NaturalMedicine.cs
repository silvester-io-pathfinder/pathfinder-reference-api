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
    public class NaturalMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("925d2a24-82e2-42c2-a402-f8f5814f149b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Medicine",
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
            yield return new TextBlock { Id = Guid.Parse("d5488c4f-4fa3-4e37-8369-9d82ebbbf3fd"), Type = TextBlockType.Text, Text = $"You can apply natural cures to heal your allies. You can use Nature instead of Medicine to {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}. If you're in the wilderness, you might have easier access to fresh ingredients, allowing you to gain a +2 circumstance bonus to your check to {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)} using Nature, subject to the GM's determination." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("18660ff5-dce5-4117-8a9f-9a7e92ffb644"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bc04895f-c302-432f-8a8c-656fe0e627df"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("c9a4f929-926e-40b9-aba6-76a1549ea23e"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57d7013b-8ade-4a7c-bb6f-2a2118ea09a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
